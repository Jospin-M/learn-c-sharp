using System;
using System.Collections.Generic;
using System.Text;

namespace CorporatePolymorphism
{
    internal class Manager : Employee
    {
        public override void SubmitDailyReport()
        {
            Console.WriteLine("Manager submits daily report.");
        }
        
        public override void Work()
        {
            Console.WriteLine("Manager oversees the project.");
        }
    }
}
