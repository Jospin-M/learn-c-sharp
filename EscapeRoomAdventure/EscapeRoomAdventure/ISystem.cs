using System;
using System.Collections.Generic;
using System.Text;

namespace EscapeRoomAdventure
{
    internal interface ISystem
    {
        public string Status { get; set; }

        public void Operate();
    }
}
