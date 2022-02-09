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
    public partial class PostponeWindow : Form
    {
        public PostponeWindow()
        {
            InitializeComponent();
            Load += PostponeWindow_Load;
        }

        private void PostponeWindow_Load(object sender, EventArgs e)
        {
            timePicker.Format = DateTimePickerFormat.Custom;
            timePicker.CustomFormat = "HH:mm";
            timePicker.ShowUpDown = true;
            chooseDateTime.Text = ProgramDictionary.words["chooseDateTime"];
            postponeReminder.Text = ProgramDictionary.words["postponeReminder"];
        }


        private void postponeReminder_Click_1(object sender, EventArgs e)
        {

        }
    }
}
