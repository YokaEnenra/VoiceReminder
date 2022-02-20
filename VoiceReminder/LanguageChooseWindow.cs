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
    internal partial class LanguageChooseWindow : Form
    {
        internal string language { get; set; }
        internal LanguageChooseWindow()
        {
            InitializeComponent();
            Load += LanguageChooseWindow_Load;
        }

        private void LanguageChooseWindow_Load(object sender, EventArgs e)
        {
            language = "none";
            languagesBox.Items.AddRange(new string[] { "English", "Українська" });
            languagesBox.SelectedIndex = 0;
            choiceOk.Text = ProgramDictionary.Words["choiceOk"];
            choiceCancel.Text = ProgramDictionary.Words["choiceCancel"];
            chooseLanguageLabel.Text = ProgramDictionary.Words["chooseLanguageLabel"];
        }

        private void choiceOk_Click(object sender, EventArgs e)
        {
            language = languagesBox.SelectedItem as string;
            Close();
        }

        private void choiseCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
