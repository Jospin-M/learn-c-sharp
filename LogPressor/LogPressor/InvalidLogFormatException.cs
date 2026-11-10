using System;
using System.Collections.Generic;
using System.Text;

namespace LogPressor
{
    internal class InvalidLogFormatException : Exception
    {
        public InvalidLogFormatException(string message) : base(message)
        {

        }
    }
}
