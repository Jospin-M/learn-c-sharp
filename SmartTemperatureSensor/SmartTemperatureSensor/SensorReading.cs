using System;
using System.Collections.Generic;
using System.Text;

namespace SmartTemperatureSensor
{
    internal class SensorReading
    {
        public decimal? Value { get; set; }
        public DateTime? LastUpdated { get; set; }
        public ReadingStatus? Status { get; private set; }

        public SensorReading()
        {
            Status = new ReadingStatus();
        }

        public void Update(decimal? value)
        {
            Value = value;

            if(value != null)
            {
                LastUpdated = DateTime.Now;
                Status.Message = "OK";
                Status.IsValid = true;
            } 
            else
            {
                LastUpdated = null;
                Status.Message = "No Reading";
                Status.IsValid = false;
            }
        }

        public string GetStatusSummary()
        {
            return $"Status: {Status?.Message ?? "Unknown"}, Valid: {Status?.IsValid ?? false}";
        }
    }
}
