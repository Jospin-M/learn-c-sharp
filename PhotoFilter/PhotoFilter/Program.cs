namespace PhotoFilter 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Test 1: Basic brightness adjustment
            Console.WriteLine("\n=== Testing CreateBrighterVersion ===");
            Image original = Image.CreateDarkImage();
            Image brightened = original.CreateBrighterVersion();
            Console.WriteLine($"Original: {original}");
            Console.WriteLine($"Brightened: {brightened}");

            // Test 2: Chain multiple adjustments
            Console.WriteLine("\n=== Testing BrightenThenSaturate ===");
            Image chained = original.BrightenThenSaturate(0.2, 0.1);
            Console.WriteLine($"Original: {original}");
            Console.WriteLine($"Chained: {chained}");

            // Test 3: Lambda transformations
            Console.WriteLine("\n=== Testing TransformBrightness ===");
            Image doubled = original.TransformBrightness(x => x * 2);
            Image halved = original.TransformBrightness(x => x / 2);
            Console.WriteLine($"Original: {original}");
            Console.WriteLine($"Doubled brightness: {doubled}");
            Console.WriteLine($"Halved brightness: {halved}");

        }
    }
}