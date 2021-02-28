using StrategyPattern.Strategies.Interfaces;
using System;
using System.Linq;

namespace StrategyPattern.Strategies.NumbersStrategies
{
    public class FormuleNumbersStrategy : INumbersStrategy
    {
        private Func<int, int, int> _formuleFunction;


        public FormuleNumbersStrategy(Func<int, int, int> formuleFunction)
        {
            SetFormuleFunction(formuleFunction);
        }

        public int Execute(params int[] numbers)
        {
            if (numbers == null || !numbers.Any())
                return 0;
            else
                return numbers.Aggregate(_formuleFunction);
        }

        public void SetFormuleFunction(Func<int, int, int> formuleFunction)
        {
            _formuleFunction = formuleFunction ?? throw new ArgumentNullException(nameof(formuleFunction));
        }
    }
}
