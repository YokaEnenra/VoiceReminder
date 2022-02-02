using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VoiceReminder
{
    public partial class MainWindow : Form
    {
        bool isRecord;
        bool userClosing;
        bool fullExit;
        public MainWindow()
        {
            InitializeComponent();
            Load += Form1_Load;
            FormClosing += MainWindow_FormClosing;
            Resize += MainWindow_Resize;
        }

        private void MainWindow_Resize(object sender, EventArgs e)
        {
            if (userClosing)
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
            if (!fullExit)
            {
                userClosing = true;
                // Отменить закрытие формы
                e.Cancel = true;
                // Вместо закрытия — свернуть
                WindowState = FormWindowState.Minimized;
            }
            else
            {
                base.Close();
            }            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timePicker.Format = DateTimePickerFormat.Custom;
            timePicker.CustomFormat = "HH:mm";
            timePicker.ShowUpDown = true;
            isRecord = false;
            fullExit = false;
            userClosing = false;
            
            
        }

        private void RecordVoice_Click(object sender, EventArgs e)
        {
            if (!isRecord)
            {
                recordIcon.Image = Properties.Resources.RecordGoes;
                isRecord = true;
            }
            else
            {
                recordIcon.Image = Properties.Resources.Record;
                isRecord = false;
            }
        }

        private void PlayVoice_Click(object sender, EventArgs e)
        {

        }

        private void DeleteVoice_Click(object sender, EventArgs e)
        {

        }

        private void CreateReminder_Click(object sender, EventArgs e)
        {

        }

        private void ShowReminders_Click(object sender, EventArgs e)
        {

        }


        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            WindowState = FormWindowState.Normal;
            userClosing = false;
        }

        private void вихідToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var closeDialog = MessageBox.Show(ProgramDictionary.words["fullExitInfo"], ProgramDictionary.words["info"], 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
           if (closeDialog == DialogResult.Yes)
            {
                fullExit = true;
                Application.Exit();
            }
        }

        private void змінитиМовуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProgramRegistry.OpenRegistry();
            Choose.Language();
            ProgramRegistry.CloseRegistry();
            MessageBox.Show(ProgramDictionary.words["changesAfter"], ProgramDictionary.words["info"], MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
