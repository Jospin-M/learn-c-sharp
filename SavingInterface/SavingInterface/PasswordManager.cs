using System;
using System.Collections.Generic;
using System.Text;

namespace SavingInterface
{
    internal class PasswordManager
    {
        private string Password { get; set; }
        public bool Hidden { get; set; }

        public PasswordManager(string password, bool hidden)
        {
            Password = password;
            Hidden = hidden;
        }
    }
}
