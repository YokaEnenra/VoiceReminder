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
        private bool _isAutorun;
        WaveIn _waveIn;
        WaveFileWriter _writer;
        private string _outputFilename;
        private string _lastRecordFile;
        private WMPLib.WindowsMediaPlayer WMP;


        internal MainWindow(bool isAutorun)
        {
            InitializeComponent();
            Load += Form1_Load;
            FormClosing += MainWindow_FormClosing;
            SizeChanged += MainWindow_Resize;
            _isAutorun = isAutorun;
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
            chooseDateTime.Text = Words["chooseDateTime"];
            chooseName.Text = Words["chooseName"];
            doRecord.Text = Words["doRecord"];
            recordVoice.Text = Words["recordVoice"];
            showReminders.Text = Words["showReminders"];
            playVoice.Text = Words["playVoice"];
            deleteVoice.Text = Words["deleteVoice"];
            createReminder.Text = Words["createReminder"];
            exitApplication.Text = Words["exitApplication"];
            showApplication.Text = Words["showApplication"];
            changeLanguageStrip.Text = Words["changeLanguageStrip"];
            viewStrip.Text = Words["viewStrip"];
            whenNotify.Text = Words["whenNotify"];
            hours.Text = Words["hours"];
            days.Text = Words["days"];
            _lastRecordFile = "0";
            if(_isAutorun)
                Autorun();
        }

        private void Autorun()
        {
            _userClosing = true;
            WindowState = FormWindowState.Minimized;
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
                e.Cancel = true;
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
                _writer.Write(e.Buffer, 0, e.BytesRecorded);
            }
        }

        void StopRecording()
        {
            _waveIn.StopRecording();
        }

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
                MessageBox.Show(Words["recordedVoice"], Words["info"], MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (!_recordGoes)
            {
                recordIcon.Image = Resources.RecordGoes;
                _recordGoes = true;
                try
                {
                    _waveIn = new WaveIn();
                    _waveIn.DeviceNumber = 0;
                    _waveIn.DataAvailable += waveIn_DataAvailable;
                    _waveIn.RecordingStopped += waveIn_RecordingStopped;
                    _waveIn.WaveFormat = new WaveFormat(8000, 1);
                    _outputFilename = ProgramDataPath + @"\Audio\" + DateTime.Now.ToString().Replace(':', '.') + ".mp3";
                    _writer = new WaveFileWriter(_outputFilename, _waveIn.WaveFormat);
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
                MessageBox.Show(Words["noFile"], Words["info"], 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show(Words["noFile"], Words["info"], MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            File.Delete(_lastRecordFile);
            _lastRecordFile = "0";
            _isRecorded = false;
        }

        private void CreateReminder_Click(object sender, EventArgs e)
        {
            if (datePicker.Value.Date + timePicker.Value.TimeOfDay <= DateTime.Now)
            {
                MessageBox.Show(Words["pastDate"], Words["info"], MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (string.IsNullOrEmpty(reminderName.Text))
            {
                MessageBox.Show(Words["noName"], Words["info"], MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string daysBefore = Get.Value(daysCount);
            string hoursBefore = Get.Value(hoursCount);
            DateTime tempDateTime = datePicker.Value.AddDays(-Convert.ToInt32(daysBefore));
            if (tempDateTime.Date < DateTime.Now.Date)
            {
                MessageBox.Show(Words["notifyDate"], Words["info"], MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (datePicker.Value.Date == DateTime.Now.Date)
            {
                tempDateTime = timePicker.Value.AddHours(-Convert.ToInt32(hoursBefore));
                if (tempDateTime.TimeOfDay <= DateTime.Now.TimeOfDay)
                {
                    MessageBox.Show(Words["notifyDate"], Words["info"], MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    return;
                }
            }

            DialogResult dialogResult;
            if (!_isRecorded)
            {
                dialogResult = MessageBox.Show(Words["noAudio"], Words["info"], MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
                if (dialogResult == DialogResult.No)
                {
                    return;
                }
            }
            
            
            dialogResult = DialogResult.No;
            dialogResult = MessageBox.Show($"{Words["newReminder"]}: {datePicker.Text}, {timePicker.Text}",
                Words["areSure"], MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.No)
                return;
            string timeNoDoubleQuotation = timePicker.Value.TimeOfDay.ToString().Replace(':','.').Remove(5, timePicker.Value.TimeOfDay.ToString().Length-5);
            var newFilePath =
                $@"{ProgramDataPath}\TextData\{daysBefore}_{hoursBefore}_{datePicker.Value.Date.ToString().Remove(10,9)}_{timeNoDoubleQuotation}.txt";
            var toWriteText = $"{reminderName.Text}\n{_lastRecordFile}";
            using (StreamWriter sw = new StreamWriter(newFilePath, false, System.Text.Encoding.Default))
            {
                sw.Write(toWriteText);
            }

            MessageBox.Show($"{Words["creationSuccess"]}: {datePicker.Text}, {timePicker.Text}", Words["info"],
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            _isRecorded = false;
            reminderName.Text = "";
            daysCount.Text = "";
            hoursCount.Text = "";
            _lastRecordFile = "0";
            datePicker.Value = DateTime.Now.Date;
            timePicker.Value = DateTime.Now;
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
            var closeDialog = MessageBox.Show(Words["fullExitInfo"], Words["info"],
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (closeDialog == DialogResult.Yes)
            {
                _fullExit = true;
                if (!_reminderCreated && _isRecorded)
                {
                    File.Delete(_lastRecordFile);
                    _lastRecordFile = "0";
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
            OpenRegistry();
            if (Choice.Language())
                MessageBox.Show(Words["changesAfter"], Words["info"], MessageBoxButtons.OK, MessageBoxIcon.Information);
            CloseRegistry();
        }
    }
}