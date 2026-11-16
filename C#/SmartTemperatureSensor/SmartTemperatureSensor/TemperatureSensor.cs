using System;
using System.Collections.Generic;
using System.Text;

namespace SmartTemperatureSensor
{
    internal class TemperatureSensor
    {
        private const decimal minTemp = 0m;
        private const decimal maxTemp = 100m;

        public SensorReading Temperature { get; set; }

        public string ValidateReading()
        {
            if(Temperature.Value == null)
            {
                return "Temperature has a null value.";
            }
            else
            {
                if(Temperature.Value is >= minTemp and <= maxTemp)
                {
                    return $"The temperature {Temperature.Value} is between {minTemp} and {maxTemp}";
                } 
                else
                {
                    return $"The temperature {Temperature.Value} is not between {minTemp} and {maxTemp}";
                }
            }
        }
    }
}
