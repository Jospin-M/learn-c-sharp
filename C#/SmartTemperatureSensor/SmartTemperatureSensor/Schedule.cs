using System;
using System.Collections.Generic;
using System.Text;

namespace SmartTemperatureSensor
{
    internal class Schedule
    {
        public decimal? DayTarget { get; set; }
        public decimal? NightTarget { get; set; }
        public const decimal DefaultTarget = 75m;

        public decimal GetCurrentTarget(bool isDayTime)
        {
            if(isDayTime)
            {
                return DayTarget ?? DefaultTarget;
            } 
            else
            {
                return NightTarget ?? DefaultTarget;
            }
        }
    }
}
