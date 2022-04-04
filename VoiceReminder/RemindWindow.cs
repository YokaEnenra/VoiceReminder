using System;
using System.IO;
using System.Text;
using System.Windows.Forms;
using static VoiceReminder.ProgramDictionary;

namespace VoiceReminder
{
    public partial class RemindWindow : Form
    {
        private WMPLib.WindowsMediaPlayer WMP;
        private bool _isPlaying;
        private bool _isFile;
        private string _currentFilePath;
        private string _lastRecordFile;

        public RemindWindow()
        {
            InitializeComponent();
            Load += RemindWindow_Load;
        }

        internal void ShowDialog(string reminderPath)
        {
            _currentFilePath = reminderPath;
            base.ShowDialog();
        }

        private void RemindWindow_Load(object sender, EventArgs e)
        {
            playVoice.Text = ProgramDictionary.Words["playVoice"];
            postponeReminder.Text = ProgramDictionary.Words["postponeReminder"];
            _isPlaying  = false;
            _isFile = false;
            ShowReminder();
        }

        private void ShowReminder()
        {
            var fileFilling = File.ReadAllLines(_currentFilePath, Encoding.GetEncoding(1251));
            reminderName.Text = fileFilling[0];
            _lastRecordFile = fileFilling[1];
            var tmp = _currentFilePath.Split('\\');
            var _date = tmp[tmp.Length - 1].Replace(".txt", "");
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

        private void postponeReminder_Click(object sender, EventArgs e)
        {
            PostponeWindow postpone = new PostponeWindow();
            postpone.ShowDialog(_currentFilePath);
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
    }
}
