using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BiblioInheritance
{
    internal class Resource
    {
        public string Title { get; private set; }
        public string Category { get; private set; }
        public string Status { get; protected set; }
        
        public Resource(string title, string category) {
            Title = title;
            Category = category;
            Status = "Available";
        }

        public virtual void UpdateStatus()
        {
            if(Status == "Available")
            {
                Status = "Out";
            } 
            else
            {
                Status = "Available";
            }
        }

        public void GetInfo()
        {
            Console.WriteLine($"Title: {Title}\nCategory: {Category}\nStatus: {Status}");
        }
    }
}
