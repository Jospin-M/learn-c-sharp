using AsynchronousRecipes;

class Program
{
    // Initial method to load recipe details
    public static async Task LoadRecipeDetailsAsync(Recipe recipe, CancellationToken cancellationToken)
    {
        Console.WriteLine($"Loading details for {recipe}...");
        
        
        Task<List<string>> ingredients = RecipeAPI.GetIngredientsAsync(recipe.Id);
        Console.WriteLine($"Loaded ingredients for {recipe}");

        Task<List<string>> instructions = RecipeAPI.GetInstructionsAsync(recipe.Id);
        Console.WriteLine($"Loaded instructions for {recipe}");

        try
        {
            await Task.WhenAll(ingredients, instructions);

            if(cancellationToken.IsCancellationRequested)
            {
                cancellationToken.ThrowIfCancellationRequested();
            }
        } 
        catch (OperationCanceledException ex)
        {
            Console.WriteLine(ex.Message);
        }

        recipe.Ingredients = ingredients.Result;
        recipe.Instructions = instructions.Result;
    }

    public static async Task<Recipe> FetchRecipeAsync(int id, CancellationToken cancellationToken)
    {
        Recipe recipe = new Recipe { Id = id };

        Console.WriteLine("Started async operation...");

        try
        {
            await RecipeAPI.GetRecipeAsync(id);

            if(cancellationToken.IsCancellationRequested)
            {
                cancellationToken.ThrowIfCancellationRequested();
            }
        }
        catch (KeyNotFoundException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (OperationCanceledException ex1)
        {
            Console.WriteLine(ex1.Message);
        }   

        Console.WriteLine("Completed async operation.");

        return recipe;
    }

    public static async Task Main(string[] args)
    {
        // Your implementation here
        Console.WriteLine("Starting Recipe Application...");

        Recipe recipe = await FetchRecipeAsync(1, default);
        await LoadRecipeDetailsAsync(recipe, default);
        recipe.Display();

        Console.WriteLine("Start fetch for recipe 2...");

        CancellationTokenSource tokenSource = new CancellationTokenSource(1000);
        Recipe recipe2 = await FetchRecipeAsync(2, tokenSource.Token);
        recipe2.Display();
    }
}