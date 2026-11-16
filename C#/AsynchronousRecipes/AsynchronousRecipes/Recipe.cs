using System;
using System.Collections.Generic;
using System.Text;

namespace AsynchronousRecipes
{
    internal class Recipe
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public List<string>? Ingredients { get; set; }
        public List<string>? Instructions { get; set; }

        public override string ToString()
        {
            return $"Recipe {Id}: {Name}";
        }

        public void Display()
        {
            Console.WriteLine($"\nRecipe: {Name}");
            Console.WriteLine("Ingredients:");
            if (Ingredients != null)
            {
                foreach (var ingredient in Ingredients)
                    Console.WriteLine($"- {ingredient}");
            }
            Console.WriteLine("Instructions:");
            if (Instructions != null)
            {
                int step = 1;
                foreach (var instruction in Instructions)
                    Console.WriteLine($"{step++}. {instruction}");
            }
            Console.WriteLine();
        }
    }
}
