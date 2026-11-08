using System;
using System.Collections.Generic;
using System.Text;

namespace EscapeRoomAdventure
{
    internal class Server : ISystem
    {
        public string Status { get; set; }

        public void Operate()
        {
            Console.WriteLine($"Server is {Status}");
        }
    }
}
