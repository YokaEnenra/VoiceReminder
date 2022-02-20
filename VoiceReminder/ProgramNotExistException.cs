using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoiceReminder
{
    internal class ProgramNotExistException : Exception
    {
        public ProgramNotExistException()
        {
            var msg = "Registry is bull or false";
        }
    }
}
