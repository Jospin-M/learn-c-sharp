using System;
using System.Collections.Generic;
using System.Text;

namespace CorporatePolymorphism
{
    internal abstract class Employee
    {
        public abstract void SubmitDailyReport();
        
        public virtual void Work()
        {
            Console.WriteLine("Employee is working.");
        }

        public void ClockIn()
        {
            Console.WriteLine("Employee clocks in.");
        }
    }
}
