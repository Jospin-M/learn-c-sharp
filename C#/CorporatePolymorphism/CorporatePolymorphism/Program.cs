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

            Employee e = new Engineer();
            e.SubmitDailyReport();

            Employee e2 = new Manager();
            e2.ClockIn();
            e2.Work();
            e2.SubmitDailyReport();

            Employee e3 = new Intern();
            e3.ClockIn();
            e3.Work();
            e3.SubmitDailyReport();

            Engineer engineer1 = (Engineer)e;

            if(engineer1 != null)
            {
                engineer1.SubmitDailyReport();
            }
            else
            {
                Console.WriteLine("Downcast failed.");
            }

            Employee[] employees = new[] { e, e2, e3, engineer1 }; 
        
            foreach(Employee employee in employees)
            {
                employee.ClockIn();
                employee.Work();
                employee.SubmitDailyReport();

                if(employee is Engineer)
                {
                    Console.WriteLine("This is an Engineer.");
                }
                else if(employee is Intern)
                {
                    Console.WriteLine("This is an Intern.");
                }
                else
                {
                    Console.WriteLine("This is a Manager");
                }
            }
        }
    }
}

