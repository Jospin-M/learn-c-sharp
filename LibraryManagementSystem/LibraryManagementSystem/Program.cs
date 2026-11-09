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

        Console.WriteLine("\n=== Add Books to Catalog ===");
        // Test add books here

        Console.WriteLine("\n=== Display Catalog ===");
        // Test catalog display here

        Console.WriteLine("\n=== Display Books by Category ===");
        // Test category display here

        Console.WriteLine("\n=== Test Book Circulation ===");
        // Test checkout and returns here
    }
}