using System;
using System.IO;
using System.Threading.Tasks;
using static VoiceReminder.ProgramRegistry;

namespace VoiceReminder
{
    internal class ReminderTracker
    {
        private static string[] allfiles;
        private static string[] reminderDate;
        private static string[] reminderTime;
        private static string daysBefore = "";
        private static string hoursBefore = "";
        private static string _currentFilePath;

        private static void GetValues(string file)
        {
            _currentFilePath = file;
            var filePathSplit = file.Split('\\');
            var date = filePathSplit[filePathSplit.Length - 1].Replace(".txt", "");
            int temp = 0;
            int counter = 0;

            for (int i = 0; i < date.Length; i++)
            {
                if (date[i] == '_')
                    counter++;
                if (counter == 2)
                {
                    temp = i;
                    break;
                }

                if (counter == 0)
                {
                    daysBefore += date[i];
                    continue;
                }

                hoursBefore += date[i];
            }

            hoursBefore = hoursBefore.Remove(0, 1);
            date = date.Remove(0, temp + 1);
            var partsDate = date.Split('_');
            reminderDate = partsDate[0].Split('.');
            reminderTime = partsDate[1].Split('.');
        }

        internal static async void StartTracking()
        {
            while(true)
            {
                allfiles = Directory.GetFiles($@"{ProgramDataPath}\TextData\", "*.*", SearchOption.AllDirectories);
                foreach (string file in allfiles)
                {
                    daysBefore = "";
                    hoursBefore = "";
                    GetValues(file);
                    DateTime date = new DateTime(Convert.ToInt32(reminderDate[2]), Convert.ToInt32(reminderDate[1]),
                        Convert.ToInt32(reminderDate[0]), Convert.ToInt32(reminderTime[0]),
                        Convert.ToInt32(reminderTime[1]), 0);
                    var compareDays = date.AddDays(-Convert.ToInt32(daysBefore));
                    if (compareDays.Date == DateTime.Now.Date &&
                        date.TimeOfDay.Hours == DateTime.Now.TimeOfDay.Hours &&
                        date.TimeOfDay.Minutes == DateTime.Now.TimeOfDay.Minutes)
                    {
                        RemindWindow remind = new RemindWindow();
                        remind.ShowDialog(_currentFilePath);
                        continue;
                    }
                    var compareHours = date.AddHours(-Convert.ToInt32(hoursBefore)).TimeOfDay;
                    if (compareHours.Hours == DateTime.Now.TimeOfDay.Hours &&
                        compareHours.Minutes == DateTime.Now.TimeOfDay.Minutes)
                    {
                        RemindWindow remind = new RemindWindow();
                        remind.ShowDialog(_currentFilePath);
                    }

                }
                await Task.Delay(60000);
            }
        }
    }
}
