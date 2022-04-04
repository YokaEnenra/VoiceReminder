using Microsoft.Win32;
using System;
using System.Windows.Forms;
using AccessViolationException = System.AccessViolationException;

namespace VoiceReminder
{
    internal static class ProgramRegistry
    {
        private static RegistryKey _currentUserKey;
        private static RegistryKey _softwareMachineKey;
        private static RegistryKey _yokaIncKey;
        internal static string ProgramDataPath;
        internal static RegistryKey VoiceReminderKey { get; set; }

        internal static void OpenRegistry()
        {
            _currentUserKey = Registry.CurrentUser;
            _softwareMachineKey = _currentUserKey.OpenSubKey("SOFTWARE", true);
            _yokaIncKey = _softwareMachineKey.OpenSubKey("YokaInc", true);
            VoiceReminderKey = _yokaIncKey.OpenSubKey("VoiceReminder", true);
        }

        internal static void CloseRegistry()
        {
            VoiceReminderKey.Close();
            _yokaIncKey.Close();
            _softwareMachineKey.Close();
            _currentUserKey.Close();
        }

        internal static void FirstRunActions()
        {
            _yokaIncKey = _softwareMachineKey.CreateSubKey("YokaInc");
            VoiceReminderKey = _yokaIncKey.CreateSubKey("VoiceReminder");
            Registry.SetValue(@"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Run\"
                , "VoiceReminder", "\"" + Application.ExecutablePath + "\"" + " /MINIMIZED");
            VoiceReminderKey.SetValue("program_data_path",
                Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\.VoiceReminder"); 
        }

        internal static object GetLanguage()
        {
            OpenRegistry();
            var language_t = (string)VoiceReminderKey.GetValue("language");
            CloseRegistry();
            return language_t;
        }

        internal static void SetLanguage(string preferredLanguage)
        {
            OpenRegistry();
            VoiceReminderKey.SetValue("language", preferredLanguage);
            CloseRegistry();
        }

        internal static bool GetDataPath()
        {
            try
            {
                OpenRegistry();
                ProgramDataPath = (string) VoiceReminderKey.GetValue("program_data_path");
                CloseRegistry();
                return true;
            }
            catch (AccessViolationException)
            {
                return false;
            }
            catch (NullReferenceException)
            {
                return false;
            }
           
        }
    }
}
