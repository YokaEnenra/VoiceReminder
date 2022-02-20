using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static VoiceReminder.ProgramDictionary;

namespace VoiceReminder
{
    public partial class RemindWindow : Form
    {
        private WMPLib.WindowsMediaPlayer WMP;
        private bool _isPlaying;
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
            ShowReminder();
        }

        private void ShowReminder()
        {
            string[] fileFilling;
            using (StreamReader sr = new StreamReader(_currentFilePath))
            {
                fileFilling = sr.ReadToEnd().Split('\n');
            }

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
        }

        private void postponeReminder_Click(object sender, EventArgs e)
        {
            PostponeWindow postpone = new PostponeWindow();
            postpone.ShowDialog(_currentFilePath);
        }

        private void playVoice_Click(object sender, EventArgs e)
        {
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
