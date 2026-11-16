using System;
using System.Collections.Generic;
using System.Text;

namespace SavingInterface
{
    internal class PasswordManager : IDisplayable, IResetable
    {
        private string Password { get; set; }
        public bool Hidden { get; set; }

        public PasswordManager(string password, bool hidden)
        {
            Password = password;
            Hidden = hidden;
        }

        public void Display()
        {
            if(Hidden == false)
            {
                Console.WriteLine(Password);
            }
            else
            {
                Console.WriteLine(new string('*', Password.Length));
            }
        }

        public void Reset()
        {
            Password = "";
            Hidden = false;
        }
    }
}
