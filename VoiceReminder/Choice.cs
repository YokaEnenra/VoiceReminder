using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoiceReminder
{
    internal static class Choice
    {
        internal static bool Language()
        {
            LanguageChooseWindow languageForm = new LanguageChooseWindow();
            languageForm.ShowDialog();
            if (languageForm.language != "none")
            {
                var preferredLanguage = languageForm.language;
                ProgramRegistry.SetLanguage(preferredLanguage);
                return true;
            }
            return false;
        }
    }
}
