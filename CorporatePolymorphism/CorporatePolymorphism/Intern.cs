using System;
using System.Collections.Generic;
using System.Text;

namespace CorporatePolymorphism
{
    internal class Intern : Employee
    {
        public override void SubmitDailyReport()
        {
            Console.WriteLine("Intern submits daily report.");
        }
        
        public override void Work()
        {
            Console.WriteLine("Intern oversees the project.");
        }
    }
}
