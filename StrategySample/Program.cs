using Common.Interfaces.Repositories;
using StrategyPattern.Contexts;
using StrategyPattern.Strategies.NumbersStrategies;
using System;
using System.Collections.Generic;
using System.Linq;
using Common.Container;

namespace StrategyPattern
{
    internal class Program
    {
        private const string resultFormat = "Result: {0}; Strategy name: {1}.";
        private const string lineSplitter = "=================";


        private static void Main(string[] args)
        {
            int result;

            NumbersContext numbersContext = new NumbersContext();

            var randomIntRepository = Container.Resolve<IRandomIntRepository>();
            var randomIntValues = randomIntRepository.GetRandomValuesRandomCount(-10, 20, 0, 7).ToArray();

            #region Show random values

            Console.WriteLine("Random values");
            ShowNumbers(randomIntValues);

            #endregion

            Console.WriteLine(lineSplitter);

            #region AddNumbersStrategy example

            numbersContext.SetNumberStrategy(new AddNumbersStrategy());
            result = numbersContext.ExecuteStrategy(randomIntValues);
            ShowResult(result, nameof(AddNumbersStrategy));

            #endregion

            #region MultiplyNumbersStrategy example

            numbersContext.SetNumberStrategy(new MultiplyNumbersStrategy());
            result = numbersContext.ExecuteStrategy(randomIntValues);
            ShowResult(result, nameof(MultiplyNumbersStrategy));

            #endregion

            #region FormuleNumbersStrategy example

            Func<int, int, int> formuleFunction = (a, b) => (int) ((a + b) * 2 / ((float)a - b));

            numbersContext.SetNumberStrategy(new FormuleNumbersStrategy(formuleFunction));
            result = numbersContext.ExecuteStrategy(randomIntValues);
            ShowResult(result, nameof(FormuleNumbersStrategy));

            #endregion

            Console.ReadKey();
        }


        private static void ShowResult(int result, string strategyName)
        {
            Console.WriteLine(string.Format(resultFormat, result, strategyName));
        }

        private static void ShowNumbers(IEnumerable<int> numbers)
        {
            foreach (int number in numbers)
            {
                Console.Write($"{number}  ");
            }

            Console.WriteLine();
        }
    }
}
