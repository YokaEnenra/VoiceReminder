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
    public partial class LanguageChooseWindow : Form
    {
        public string language { get; set; }
        public LanguageChooseWindow()
        {
            InitializeComponent();
            Load += LanguageChooseWindow_Load;
        }

        private void LanguageChooseWindow_Load(object sender, EventArgs e)
        {
            language = "none";
            languagesBox.Items.AddRange(new string[] { "English", "Українська" });
            languagesBox.SelectedIndex = 0;
        }

        private void choiceOk_Click(object sender, EventArgs e)
        {
            language = languagesBox.SelectedItem as string;
            Close();
        }

        private void choiseCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
