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

            Book b = new Book("Code: The Hidden Language of Computer Hardware and Software", "Non-Fiction", "Charles Petzold", 396);
            b.GetInfo();

            Periodical p = new Periodical("Wired", "Technology", "Monthly");
            p.UpdateStatus();

            Console.WriteLine(p.Status);

            Video v = new Video(title: "Ex Machina", director: "Alex Garland", category: "Sci-Fi", runtime: 100, mediaType: "On-Demand");
            v.GetInfo();
        }
    }
}
