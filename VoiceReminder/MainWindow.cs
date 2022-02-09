using NAudio.Wave;
using System;
using System.IO;
using System.Windows.Forms;
using VoiceReminder.Properties;
using static VoiceReminder.ProgramDictionary;
using static VoiceReminder.ProgramRegistry;

namespace VoiceReminder
{
    internal partial class MainWindow : Form
    {
        private bool _recordGoes;
        private bool _userClosing;
        private bool _fullExit;
        private bool _isRecorded;
        private bool _isPlaying;
        private bool _reminderCreated;
        // WaveIn - поток для записи
        WaveIn _waveIn;
        //Класс для записи в файл
        WaveFileWriter _writer;
        //Имя файла для записи
        private string _outputFilename;
        private string _lastRecordFile;
        private WMPLib.WindowsMediaPlayer WMP;
        internal MainWindow()
        {
            InitializeComponent();
            Load += Form1_Load;
            FormClosing += MainWindow_FormClosing;
            Resize += MainWindow_Resize;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timePicker.Format = DateTimePickerFormat.Custom;
            timePicker.CustomFormat = "HH:mm";
            timePicker.ShowUpDown = true;
            _recordGoes = false;
            _isRecorded = false;
            _fullExit = false;
            _userClosing = false;
            _isPlaying = false;
            _reminderCreated = false;
            chooseDateTime.Text = words["chooseDateTime"];
            chooseName.Text = words["chooseName"];
            doRecord.Text = words["doRecord"];
            recordVoice.Text = words["recordVoice"];
            showReminders.Text = words["showReminders"];
            playVoice.Text = words["playVoice"];
            deleteVoice.Text = words["deleteVoice"];
            createReminder.Text = words["createReminder"];
            exitApplication.Text = words["exitApplication"];
            showApplication.Text = words["showApplication"];
            changeLanguageStrip.Text = words["changeLanguageStrip"];
            viewStrip.Text = words["viewStrip"];
            whenNotify.Text = words["whenNotify"];
            hours.Text = words["hours"];
            days.Text = words["days"];
            _lastRecordFile = "0";
        }

        private void MainWindow_Resize(object sender, EventArgs e)
        {
            if (_userClosing)
            {
                if (WindowState == FormWindowState.Minimized)
                {
                    ShowInTaskbar = false;
                    notifyIcon1.Visible = true;
                }
                else
                {
                    ShowInTaskbar = true;
                    notifyIcon1.Visible = false;
                }
            }
            else
            {
                base.OnResize(e);
            }
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!_fullExit)
            {
                _userClosing = true;
                // Отменить закрытие формы
                e.Cancel = true;
                // Вместо закрытия — свернуть
                WindowState = FormWindowState.Minimized;
            }
            else
            {
                Close();
            }
        }



        void waveIn_DataAvailable(object sender, WaveInEventArgs e)
        {
            if (InvokeRequired)
            {
                BeginInvoke(new EventHandler<WaveInEventArgs>(waveIn_DataAvailable), sender, e);
            }
            else
            {
                //Записываем данные из буфера в файл
                _writer.WriteData(e.Buffer, 0, e.BytesRecorded);
            }
        }
        //Завершаем запись
        void StopRecording()
        {
            _waveIn.StopRecording();
        }
        //Окончание записи
        private void waveIn_RecordingStopped(object sender, EventArgs e)
        {
            if (InvokeRequired)
            {
                BeginInvoke(new EventHandler(waveIn_RecordingStopped), sender, e);
            }
            else
            {
                _waveIn.Dispose();
                _waveIn = null;
                _writer.Close();
                _writer = null;
            }
        }

        private void RecordVoice_Click(object sender, EventArgs e)
        {
            if (_isRecorded)
            {
                MessageBox.Show(words["recordedVoice"], words["info"], MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (!_recordGoes)
            {
                recordIcon.Image = Resources.RecordGoes;
                _recordGoes = true;
                try
                {
                    _waveIn = new WaveIn();
                    //Дефолтное устройство для записи (если оно имеется)
                    //встроенный микрофон ноутбука имеет номер 0
                    _waveIn.DeviceNumber = 0;
                    //Прикрепляем к событию DataAvailable обработчик, возникающий при наличии записываемых данных
                    _waveIn.DataAvailable += waveIn_DataAvailable;
                    //Прикрепляем обработчик завершения записи
                    _waveIn.RecordingStopped += waveIn_RecordingStopped;
                    //Формат wav-файла - принимает параметры - частоту дискретизации и количество каналов(здесь mono)
                    _waveIn.WaveFormat = new WaveFormat(8000, 1);
                    //Инициализируем объект WaveFileWriter
                    _outputFilename = programDataPath + @"\Audio\" + DateTime.Now.ToString().Replace(':', '.') + ".mp3";
                    _writer = new WaveFileWriter(_outputFilename, _waveIn.WaveFormat);
                    //Начало записи
                    _waveIn.StartRecording();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                recordIcon.Image = Resources.Record;
                _recordGoes = false;
                StopRecording();
                _lastRecordFile = _outputFilename;
                _isRecorded = true;
            }
        }

        private void PlayVoice_Click(object sender, EventArgs e)
        {
            if (!_isRecorded)
            {
                MessageBox.Show(words["noFile"], words["info"], MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!_isPlaying)
            {
                WMP = new WMPLib.WindowsMediaPlayer();
                WMP.URL = _lastRecordFile;
                WMP.controls.play();
                _isPlaying = true;
            }
            else
            {
                WMP.controls.stop();
                _isPlaying = false;
            }
        }

        private void DeleteVoice_Click(object sender, EventArgs e)
        {
            if (!_isRecorded)
            {
                MessageBox.Show(words["noFile"], words["info"], MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            File.Delete(_lastRecordFile);
            _isRecorded = false;
        }

        private void CreateReminder_Click(object sender, EventArgs e)
        {
            if (datePicker.Value.Date + timePicker.Value.TimeOfDay <= DateTime.Now)
            {
                MessageBox.Show(words["pastDate"], words["info"], MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (String.IsNullOrEmpty(reminderName.Text))
            {
                MessageBox.Show(words["noName"], words["info"], MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string daysBefore = GetValue(daysCount);
            string hoursBefore = GetValue(hoursCount);
            DateTime tempDateTime = datePicker.Value.AddDays(-Convert.ToInt32(daysBefore));
            if (tempDateTime.Date < DateTime.Now.Date)
            {
                MessageBox.Show(words["notifyDate"], words["info"], MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (datePicker.Value.Date == DateTime.Now.Date)
            {
                tempDateTime = timePicker.Value.AddHours(-Convert.ToInt32(hoursBefore));
                if (tempDateTime.TimeOfDay <= DateTime.Now.TimeOfDay)
                {
                    MessageBox.Show(words["notifyDate"], words["info"], MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    return;
                }
            }

            DialogResult dialogResult;
            if (!_isRecorded)
            {
                dialogResult = MessageBox.Show(words["noAudio"], words["info"], MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
                if (dialogResult == DialogResult.No)
                {
                    return;
                }
            }
            
            
            dialogResult = DialogResult.No;
            dialogResult = MessageBox.Show($"{words["newReminder"]}: {datePicker.Text}, {timePicker.Text}",
                words["areSure"], MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.No)
                return;
            string timeNoDoubleQuotation = timePicker.Value.TimeOfDay.ToString().Replace(':','.').Remove(5,3);
            var newFilePath =
                $@"{programDataPath}\TextData\{daysBefore}_{hoursBefore}_{datePicker.Value.Date.ToString().Remove(10,9)}_{timeNoDoubleQuotation}.txt";
            var toWriteText = $"{reminderName.Text}\n{_lastRecordFile}";
            using (StreamWriter sw = new StreamWriter(newFilePath, false, System.Text.Encoding.Default))
            {
                sw.Write(toWriteText);
            }

            MessageBox.Show($"{words["creationSuccess"]}: {datePicker.Text}, {timePicker.Text}", words["info"],
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            _isRecorded = false;
            reminderName.Text = "";
            daysCount.Text = "";
            hoursCount.Text = "";
            _lastRecordFile = "";
            datePicker.Value = DateTime.Now.Date;
            timePicker.Value = DateTime.Now;
        }

        private string GetValue(TextBox smthCount)
        {
            string someValue;
            try
            {
                someValue = Convert.ToInt32(smthCount.Text).ToString();
            }
            catch (FormatException)
            {
                someValue = "0";
            }
            return someValue;
        }

        private void ShowReminders_Click(object sender, EventArgs e)
        {
            ShowReminders show = new ShowReminders();
            Hide();
            show.ShowDialog();
            Show();
        }


        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            WindowState = FormWindowState.Normal;
            _userClosing = false;
        }

        private void exitApplication_Click(object sender, EventArgs e)
        {
            var closeDialog = MessageBox.Show(ProgramDictionary.words["fullExitInfo"], ProgramDictionary.words["info"],
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (closeDialog == DialogResult.Yes)
            {
                _fullExit = true;
                if (!_reminderCreated && _isRecorded)
                {
                    File.Delete(_lastRecordFile);
                }
                Application.Exit();
            }
        }

        private void showApplication_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            _userClosing = false;
        }

        private void changeLanguageStrip_Click(object sender, EventArgs e)
        {
            ProgramRegistry.OpenRegistry();
            if (Choice.Language())
                MessageBox.Show(ProgramDictionary.words["changesAfter"], ProgramDictionary.words["info"], MessageBoxButtons.OK, MessageBoxIcon.Information);
            ProgramRegistry.CloseRegistry();
        }

        private void Surprise(object sender, EventArgs e)
        {
            WMP = new WMPLib.WindowsMediaPlayer();
            WMP.URL = AppDomain.CurrentDomain.BaseDirectory + "someSpecialSound.mp3";
            WMP.controls.play();
            notifyIcon1.ContextMenuStrip = contextMenuStrip2;
            notifyIcon1.Visible = true;
        }

        private void даТыЗаебалСтопБлятьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WMP.controls.stop();
            notifyIcon1.ContextMenuStrip = contextMenuStrip1;
            notifyIcon1.Visible = false;
        }

    }
}
