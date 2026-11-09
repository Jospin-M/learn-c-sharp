using LibraryManagementSystem;

internal class Program
{
    static void Main(string[] args)
    {
        Book book1 = new Book
        {
            ISBN = "123",
            Title = "Whispers of the Cosmic Winds",
            Author = "Elena Starling",
            Category = "Science Fiction"
        };

        Book book2 = new Book
        {
            ISBN = "456",
            Title = "The Last Algorithm",
            Author = "Marcus Chen",
            Category = "Technology"
        };

        LibrarySystem library = new LibrarySystem();

        Console.WriteLine("\n=== Add Books to Catalog ===");
        // Test add books here
        library.AddBook(book1);
        library.AddBook(book2);

        Console.WriteLine("\n=== Display Catalog ===");
        // Test catalog display here
        library.DisplayCatalog();

        Console.WriteLine("\n=== Display Books by Category ===");
        // Test category display here
        library.DisplayBooksByCategory("Non-Fiction");
        library.DisplayBooksByCategory("Technology");

        Console.WriteLine("\n=== Test Book Circulation ===");
        // Test checkout and returns here
        Console.WriteLine(library.CheckOutBook("456"));
        Console.WriteLine(library.CheckOutBook("456"));

        library.CheckOutBook("123");
        library.ReturnBook("123");
        library.ProcessReshelveCart();
    }
}