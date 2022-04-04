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
        
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            try
            {
                if (!GetDataPath())
                    throw new ProgramNotExistException();
            }
            catch (ProgramNotExistException)
            {
                FirstRunActions();
                Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) +
                                          @"\.VoiceReminder\Audio");
                Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) +
                                          @"\.VoiceReminder\TextData");
                GetDataPath();

            }
            if (GetLanguage() == null)
            {
                if (!Choice.Language())
                {
                    return;
                }
                
            }
            
            ProgramDictionary.Set();
            CloseRegistry();

            bool onlyInstance;

            Mutex mtx = new Mutex(true, "VoiceReminder", out onlyInstance);
            if (onlyInstance)
            {
                Task.Run(ReminderTracker.StartTracking);
                try
                {
                    Application.Run(args[0].Equals("/MINIMIZED") ? new MainWindow(true) : new MainWindow(false));
                }
                catch (IndexOutOfRangeException)
                {
                    Application.Run(new MainWindow(false));
                }
                    
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
