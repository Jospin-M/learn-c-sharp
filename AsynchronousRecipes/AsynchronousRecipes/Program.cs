class Program
{
    // Initial method to load recipe details
    public static async Task LoadRecipeDetailsAsync(Recipe recipe)
    {
        Console.WriteLine($"Loading details for {recipe}...");
        recipe.Ingredients = await RecipeAPI.GetIngredientsAsync(recipe.Id);
        Console.WriteLine($"Loaded ingredients for {recipe}");

        recipe.Instructions = await RecipeAPI.GetInstructionsAsync(recipe.Id);
        Console.WriteLine($"Loaded instructions for {recipe}");
    }

    public static void Main(string[] args)
    {
        // Your implementation here
        Console.WriteLine("Starting Recipe Application...");
    }
}