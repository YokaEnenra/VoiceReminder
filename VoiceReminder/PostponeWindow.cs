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
using static VoiceReminder.ProgramRegistry;

namespace VoiceReminder
{
    public partial class PostponeWindow : Form
    {
        private string _oldFilePath;

        public PostponeWindow()
        {
            InitializeComponent();
            Load += PostponeWindow_Load;
        }

        internal void ShowDialog(string reminderPath)
        {
            _oldFilePath = reminderPath;
            base.ShowDialog();
        }

        private void PostponeWindow_Load(object sender, EventArgs e)
        {
            timePicker.Format = DateTimePickerFormat.Custom;
            timePicker.CustomFormat = "HH:mm";
            timePicker.ShowUpDown = true;
            chooseDateTime.Text = ProgramDictionary.Words["chooseDateTime"];
            postponeReminder.Text = ProgramDictionary.Words["postponeReminder"]; 
            whenNotify.Text = Words["whenNotify"];
            hours.Text = Words["hours"];
            days.Text = Words["days"];
        }


        private void postponeReminder_Click_1(object sender, EventArgs e)
        {
            if (datePicker.Value.Date + timePicker.Value.TimeOfDay <= DateTime.Now)
            {
                MessageBox.Show(Words["pastDate"], Words["info"], MessageBoxButtons.OK, MessageBoxIcon.Information);
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

            var dialogResult = MessageBox.Show($"{Words["newReminder"]}: {datePicker.Text}, {timePicker.Text}",
                Words["areSure"], MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.No)
                return;
            string timeNoDoubleQuotation = timePicker.Value.TimeOfDay.ToString().Replace(':','.').Remove(5,3);
            var newFilePath =
                $@"{programDataPath}\TextData\{daysBefore}_{hoursBefore}_{datePicker.Value.Date.ToString().Remove(10,9)}_{timeNoDoubleQuotation}.txt";
            /*var toWriteText = $"{reminderName.Text}\n{_lastRecordFile}";
            using (StreamWriter sw = new StreamWriter(newFilePath, false, System.Text.Encoding.Default))
            {
                sw.Write(toWriteText);
            }*/
            File.Move(_oldFilePath,newFilePath);
            MessageBox.Show($"{Words["creationSuccess"]}: {datePicker.Text}, {timePicker.Text}", Words["info"],
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
