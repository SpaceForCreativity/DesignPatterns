using DecoratorPattern.Ingredients;
using System;

namespace DecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var teaIngredients = new Water(new TeaBag(new Sugar(null)));
            Console.WriteLine(teaIngredients.GetIngredient());
        }
    }
}
