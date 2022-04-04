namespace VoiceReminder
{
    internal static class Choice
    {
        internal static bool Language()
        {
            LanguageChooseWindow languageForm = new LanguageChooseWindow();
            languageForm.ShowDialog();
            if (languageForm.Language != "none")
            {
                var preferredLanguage = languageForm.Language;
                ProgramRegistry.SetLanguage(preferredLanguage);
                return true;
            }
            return false;
        }
    }
}