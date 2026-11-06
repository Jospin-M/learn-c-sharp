using System;
using System.Collections.Generic;
using System.Text;

namespace BiblioInheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Resource test = new Resource("Hunger Games", "Fiction");
            test.GetInfo();
        }
    }
}
