using StatePattern.Models;
using System;

namespace StatePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var water = new Water();
            water.BeforeFreeze += () => Console.WriteLine($"Water start to freeze. Current state is {water.State}");
            water.AfterFreeze += () => Console.WriteLine($"Water frozen. New state is {water.State}.");
            water.BeforeWarmUp += () => Console.WriteLine($"Water start to warm up. Current state is {water.State}");
            water.AfterWarmUp += () => Console.WriteLine($"Water warmed up. New state is {water.State}.");

            water.Freeze();

            Console.WriteLine();

            water.WarmUp();

            Console.WriteLine();

            water.WarmUp();

            Console.ReadKey();
        }
    }
}
