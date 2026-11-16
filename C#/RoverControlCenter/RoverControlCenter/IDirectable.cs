using System;
using System.Collections.Generic;
using System.Text;

namespace RoverControlCenter
{
    internal interface IDirectable
    {
        public string GetInfo();
        public string Explore();
        public string Collect();
    }
}
