using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VoiceReminder
{
    internal static class Get
    {
        internal static string Value(TextBox smthCount)
        {
            string someValue;
            try
            {
                someValue = Convert.ToInt32(smthCount.Text).ToString();
            }
            catch (FormatException)
            {
                someValue = "0";
            }
            return someValue;
        }
    }
}
