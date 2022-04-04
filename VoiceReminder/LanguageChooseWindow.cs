using System;
using System.Windows.Forms;

namespace VoiceReminder
{
    internal partial class LanguageChooseWindow : Form
    {
        internal string Language { get; private set; }
        internal LanguageChooseWindow()
        {
            InitializeComponent();
            Load += LanguageChooseWindow_Load;
        }

        private void LanguageChooseWindow_Load(object sender, EventArgs e)
        {
            Language = "none";
            languagesBox.Items.AddRange(new object[] { "English", "Українська" });
            languagesBox.SelectedIndex = 0;
            choiceOk.Text = ProgramDictionary.Words["choiceOk"];
            choiceCancel.Text = ProgramDictionary.Words["choiceCancel"];
            chooseLanguageLabel.Text = ProgramDictionary.Words["chooseLanguageLabel"];
        }

        private void choiceOk_Click(object sender, EventArgs e)
        {
            Language = languagesBox.SelectedItem as string;
            Close();
        }

        private void choiceCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}