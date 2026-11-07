using System;
using System.Collections.Generic;
using System.Text;

namespace BiblioInheritance
{
    internal class Book : Resource 
    {
        public string Author { get; private set; }
        public int PageCount { get; private set; }

        public Book(
            string title, 
            string category, 
            string author, 
            int pageCount
        ) : base(title, category)
        {
            Author = author;
            PageCount = pageCount;
        }
    }
}
