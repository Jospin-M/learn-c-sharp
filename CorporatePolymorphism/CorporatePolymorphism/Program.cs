using System;
using System.Collections.Generic;
using System.Text;

namespace CorporatePolymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HR h = new HR();
            h.ClockIn();
            h.Work();
            h.SubmitDailyReport();
        }
    }
}

