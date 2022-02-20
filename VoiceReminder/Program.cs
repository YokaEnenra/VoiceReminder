using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static VoiceReminder.ProgramRegistry;

namespace VoiceReminder
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread] 
        
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            try
            {
                OpenRegistry();
                if (!ProgramExistence() || !GetDataPath())
                {
                    throw new ProgramNotExistException();
                }
            }
            catch (Exception)
            {
                FirstRunActions();
                Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\.VoiceReminder\Audio");
                Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\.VoiceReminder\TextData");

            }
            if (GetLanguage() == "none" || GetLanguage() == null)
            {
                if (!Choice.Language())
                {
                    return;
                }
                
            }
            
            ProgramDictionary.Set();
            CloseRegistry();

            bool onlyInstance;

            Mutex mtx = new Mutex(true, "VoiceReminder", out onlyInstance); // используйте имя вашего приложения

            // Если другие процессы не владеют мьютексом, то
            // приложение запущено в единственном экземпляре
            if (onlyInstance)
            {
                Start = DateTime.Now;
                Task.Run(ReminderTracker.StartTracking);
                Application.Run(new MainWindow());
            }
            else
            {
                MessageBox.Show(
                    ProgramDictionary.Words["applicationWorking"],
                   ProgramDictionary.Words["info"],
                   MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
    }
}
