using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryManagementSystem
{
    internal class Library
    {
        private List<Book> Books { get; set; }

        public Library()
        {
            Books = [];
        }

        public void AddBook(Book book)
        {
            Books.Add(book);
        }   

        public List<Book> SearchBookByTitle(string title)
        {
            return Books.FindAll(b => b.Title == title);
        }

        public void DisplayAllBooks()
        {
            Books.ForEach(book => Console.WriteLine(book.Title));
        }
    }
}
