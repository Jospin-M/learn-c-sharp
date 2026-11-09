using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryManagementSystem
{
    internal class Book
    {
        public string ISBN { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Category { get; set; }
        public bool IsCheckedOUt { get; set; }

        public Book()
        {
            ISBN = "";
            Title = "";
            Author = "";
            Category = "";
            IsCheckedOUt = false;
        }


        public override string ToString()
        {
            return $"{Title} by {Author} (ISBN: {ISBN}, Category: {Category})";
        }
    }
}
