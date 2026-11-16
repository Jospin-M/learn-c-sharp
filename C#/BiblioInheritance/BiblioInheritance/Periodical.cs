using System;
using System.Collections.Generic;
using System.Text;

namespace BiblioInheritance
{
    internal class Periodical : Resource
    {
        public string Period { get; private set; }

        public Periodical(
            string title,
            string category,
            string period
        ) : base(title, category)
        {
            Period = period;
        }

        public override void UpdateStatus()
        {
            if(Status == "Available")
            {
                Status = "In-use";
            }
            else
            {
                Status = "Available";
            }
        }
    }
}
