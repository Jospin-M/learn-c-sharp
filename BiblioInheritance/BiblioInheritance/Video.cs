using System;
using System.Collections.Generic;
using System.Text;

namespace BiblioInheritance
{
    internal class Video : Resource
    {
        public string Director { get; private set; }
        public int Runtime { get; private set; }
        public string MediaType { get; private set; } 

        public Video(
            string title,
            string category,
            string director,
            int runtime,
            string mediaType
        ) : base(title, category)
        {
            Director = director;
            Runtime = runtime;
            MediaType = mediaType;
        }

        public override void UpdateStatus()
        {
            Console.WriteLine($"Title: {Title}\nCategory: {Category}\nStatus: {Status}\nDirector: {Director}\nRuntime: {Runtime}\nMedia Type: {Runtime}");
        }
    }
}
