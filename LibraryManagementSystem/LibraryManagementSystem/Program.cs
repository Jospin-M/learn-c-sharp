using LibraryManagementSystem;

internal class Program
{
    static void Main(string[] args) 
    {
        Library library = new Library();
        library.AddBook(new Book("1984", "George Orwell"));
        library.AddBook(new Book("To Kill a Mockingbird", "Harper Lee"));

        List<Book> results = library.SearchBookByTitle("1984");

        foreach(Book result in results)
        {
            Console.WriteLine(result.Title);
        }
    }
}