using System;
using System.Collections.Generic;
using static VoiceReminder.ProgramRegistry;

namespace VoiceReminder
{
    internal static class ProgramDictionary
    {

        
        internal static Dictionary<string, string> Words = new Dictionary<string, string>
            {
                {"info","0"},
                {"chooseLanguageLabel","Choose Preferred Language"},
                {"choiceOk","OK"},
                {"choiceCancel","Cancel"},
                {"playVoice","0"},
                {"deleteReminder","0"},
                {"recordVoice","0"},
                {"deleteVoice","0"},
                {"createReminder","0"},
                {"showReminders","0"},
                {"doRecord","0"},
                {"chooseDateTime","0"},
                {"chooseName","0"},
                {"writeTopic","0"},
                {"postponeReminder","0"},
                {"applicationWorking","0"},
                {"fullExitInfo","0"},
                {"changesAfter","0"},
                {"showApplication","0"},
                {"exitApplication","0"},
                {"changeLanguageStrip","0"},
                {"viewStrip","0"},
                {"newReminder","0"},
                {"areSure","0"},
                {"recordedVoice","0"},
                {"noFile","0"},
                {"whenNotify","0"},
                {"days","0"},
                {"hours","0"},
                {"pastDate","0"},
                {"noAudio","0"},
                {"noName","0"},
                {"notifyDate","0"},
                {"creationSuccess","0"},
                {"reminderIs","0"}
            };
        internal static void Set()
        {
            switch (GetLanguage())
            {
                case "English":
                    Words["info"] = "Information";
                    Words["chooseLanguageLabel"] = "Choose Preferred Language";
                    Words["choiceOk"] = "OK";
                    Words["choiceCancel"] = "Cancel";
                    Words["playVoice"] = "Listen";
                    Words["deleteReminder"] = "Delete Reminder";
                    Words["recordVoice"] = "Record";
                    Words["deleteVoice"] = "Delete";
                    Words["createReminder"] = "Create Reminder";
                    Words["showReminders"] = "View Reminders";
                    Words["doRecord"] = "Record Voice Notification";
                    Words["chooseDateTime"] = "Choose reminder's date and time";
                    Words["chooseName"] = "Choose reminder's name";
                    Words["writeTopic"] = "Write short text";
                    Words["postponeReminder"] = "Postpone Reminder";
                    Words["applicationWorking"] = "Application already working";
                    Words["fullExitInfo"] = "Attention!\nAfter a complete exit, " +
                                            "application will stop monitoring notifications " +
                                            "and will not notify you at the right time.";
                    Words["changesAfter"] = "Changes will take effect after restarting the program.";
                    Words["showApplication"] = "Show";
                    Words["exitApplication"] = "Exit";
                    Words["changeLanguageStrip"] = "Change language";
                    Words["viewStrip"] = "View";
                    Words["newReminder"] = "Reminder will be created for: ";
                    Words["areSure"] = "Create reminder?";
                    Words["recordedVoice"] = "You have already recorded a voice message, first create a reminder with it or delete it.";
                    Words["noFile"] = "You haven't recorded anything yet";
                    Words["whenNotify"] = "In how many days / hours to notify?";
                    Words["days"] = "Days";
                    Words["hours"] = "Hours";
                    Words["noAudio"] = "Do you really want to create a reminder without audio?";
                    Words["pastDate"] = "This date has passed";
                    Words["noName"] = "Enter a name for the reminder";
                    Words["notifyDate"] = "Notification date has passed";
                    Words["creationSuccess"] = "Reminder created for: ";
                    Words["reminderIs"] = "The event will take place on ";
                    break;
                case "Українська":
                    Words["info"] = "Інформація!";
                    Words["chooseLanguageLabel"] = "Виберіть бажану мову!";
                    Words["choiceOk"] = "ОК";
                    Words["choiceCancel"] = "Скасувати";
                    Words["playVoice"] = "Слухати";
                    Words["deleteReminder"] = "Видалити нагадування";
                    Words["recordVoice"] = "Запис";
                    Words["deleteVoice"] = "Видалити";
                    Words["createReminder"] = "Створити нагадування";
                    Words["showReminders"] = "Переглянути нагадування";
                    Words["doRecord"] = "Записати голосове сповіщення";
                    Words["chooseDateTime"] = "Виберіть дату та час нагадування";
                    Words["chooseName"] = "Виберіть назву нагадування";
                    Words["writeTopic"] = "Написати короткий текст";
                    Words["postponeReminder"] = "Відкласти нагадування";
                    Words["applicationWorking"] = "Програма вже працює";
                    Words["fullExitInfo"] = "Увага!\nПісля повного виходу " +
                                            "програма припинить моніторинг сповіщень " +
                                            "і не повідомить вас у потрібний час.";
                    Words["changesAfter"] = "Зміни набудуть чинності після перезапуску програми.";
                    Words["showApplication"] = "Показати";
                    Words["exitApplication"] = "Вийти";
                    Words["changeLanguageStrip"] = "Змінити мову";
                    Words["viewStrip"] = "Перегляд";
                    Words["newReminder"] = "Нагадування буде створено на: ";
                    Words["areSure"] = "Створити нагадування?";
                    Words["recordedVoice"] = "Ви вже записали голосове повідомлення, спочатку створіть нагадування з ним або видаліть його.";
                    Words["noFile"] = "Ви ще нічого не записали.";
                    Words["whenNotify"] = "За скільки днів/годин повідомити";
                    Words["days"] = "Дні";
                    Words["hours"] = "Години";
                    Words["noAudio"] = "Дійсно хочете створити нагадування без аудіо";
                    Words["pastDate"] = "Ця дата вже пройшла";
                    Words["noName"] = "Вкажіть ім'я нагадування";
                    Words["notifyDate"] = "Дата повідомлення пройшла";
                    Words["creationSuccess"] = "Нагадування створено на: ";
                    Words["reminderIs"] = "Подія відбудеться у ";
                    break;
            }
        }
    }
}
