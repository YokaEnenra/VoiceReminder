using System;
using System.IO;
using System.Text;
using System.Windows.Forms;
using static VoiceReminder.ProgramDictionary;
using static VoiceReminder.ProgramRegistry;


namespace VoiceReminder
{

    public partial class ShowReminders : Form
    {
        private int index;
        private string[] allfiles;
        private bool _isPlaying;
        private bool _isFile;
        private WMPLib.WindowsMediaPlayer WMP;
        private string _lastRecordFile;
        private string _currentPath;
        private string _date;

        public ShowReminders()
        {
            InitializeComponent();
            Load += ShowReminders_Load;
        }

        private void ShowReminders_Load(object sender, EventArgs e)
        {
            playVoice.Text = Words["playVoice"];
            deleteReminder.Text = Words["deleteReminder"];
            postponeReminder.Text = Words["postponeReminder"];
            allfiles = Directory.GetFiles($@"{ProgramDataPath}\TextData\", "*.*", SearchOption.AllDirectories);
            _isPlaying = false;
            _isFile = false;
            index = 0;
            NewReminder();
        }

        private void deleteReminder_Click(object sender, EventArgs e)
        {
            if (reminderName.Text.Equals("") && reminderText.Text.Equals(""))
                return;
            File.Delete(_lastRecordFile);
            File.Delete(_currentPath);
            allfiles = Directory.GetFiles($@"{ProgramDataPath}\TextData\", "*.*", SearchOption.AllDirectories);
            index = 0;
            NewReminder();
        }

        private void playVoice_Click(object sender, EventArgs e)
        {
            if (!_isFile)
            {
                MessageBox.Show(Words["noAudioRecorded"], Words["info"], MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void postponeReminder_Click(object sender, EventArgs e)
        {
            if (reminderName.Text.Equals("") && reminderText.Text.Equals(""))
                return;
            PostponeWindow postpone = new PostponeWindow();
            postpone.ShowDialog(allfiles[index]);
        }

        private void nextReminder_Click(object sender, EventArgs e)
        {
            if (index != allfiles.Length - 1)
                index++;
            else
                index = 0;

            NewReminder();
        }

        private void NewReminder()
        {
            try
            {
                var fileFilling = File.ReadAllLines(allfiles[index], Encoding.GetEncoding(1251));
                reminderName.Text = fileFilling[0];
                _lastRecordFile = fileFilling[1];
                _currentPath = allfiles[index];
                var tmp = _currentPath.Split('\\');
                _date = tmp[tmp.Length - 1].Replace(".txt", "");
                int temp = 0;
                int counter = 0;
                for (int i = 0; i < _date.Length; i++)
                {
                    if (_date[i] == '_')
                        counter++;
                    if (counter == 2)
                    {
                        temp = i;
                        break;
                    }
                }

                _date = _date.Remove(0, temp + 1);
                var partsDate = _date.Split('_');
                partsDate[1] = partsDate[1].Replace('.', ':');
                reminderText.Text = $"{Words["reminderIs"]} {partsDate[0]} {partsDate[1]}";
                if (_lastRecordFile.Equals("0"))
                {
                    _isFile = false;
                    return;
                }

                _isFile = true;
            }
            catch (IndexOutOfRangeException)
            {
                reminderName.Text = "";
                reminderText.Text = "";
                _lastRecordFile = "0";
            }
        }

        private void previousReminder_Click(object sender, EventArgs e)
        {
            if (index != 0)
                index--;
            else
                index = allfiles.Length - 1;

            NewReminder();
        }
    }
}
