using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryManagementSystem
{
    internal class LibrarySystem
    {
        private LinkedList<Book> _catalog;
        private Dictionary<string, List<Book>> _booksByCategory;
        private Stack<Book> _reshelveCart;

        public LibrarySystem()
        {
            _catalog = new LinkedList<Book>();
            _booksByCategory = new Dictionary<string, List<Book>>();
            _reshelveCart = new Stack<Book>();
        }

        public void AddBook(Book book)
        {
            _catalog.AddLast(book);

            if (_booksByCategory.ContainsKey(book.Category))
            {
                _booksByCategory[book.Category].Add(book);
            }
            else
            {
                _booksByCategory[book.Category] = new List<Book> { book };
            }

            Console.WriteLine($"{book} has been added to the catalog.");
        }

        public void DisplayCatalog()
        {
            foreach (Book book in _catalog)
            {
                Console.WriteLine(book);
            }

            Console.WriteLine($"Book count: {_catalog.Count}");
        }

        public void DisplayBooksByCategory(string category)
        {
            if (!(_booksByCategory.ContainsKey(category)))
            {
                Console.WriteLine($"The library doesn't contain any books in the category: {category}.");

                return;
            }

            Console.WriteLine($"Books in the {category} section:");

            List<Book> books = _booksByCategory[category];

            foreach (Book book in books)
            {
                Console.WriteLine(book);
            }
        }

        public bool CheckOutBook(string ISBN)
        {
            return false;
        }
    }
}
