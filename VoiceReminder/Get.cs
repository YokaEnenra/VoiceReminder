using System.Windows.Forms;

namespace VoiceReminder
{
    internal static class Get
    {
        internal static string Value(TextBox smthCount) =>
            int.TryParse(smthCount.Text, out var result) ? result.ToString() : "0";
    }
}