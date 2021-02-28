using StrategyPattern.Strategies.Interfaces;
using System;

namespace StrategyPattern.Contexts
{
    public class NumbersContext
    {
        private INumbersStrategy _numbersStrategy;


        public void SetNumberStrategy(INumbersStrategy numbersStrategy)
        {
            _numbersStrategy = numbersStrategy ?? throw new ArgumentNullException(nameof(numbersStrategy));
        }

        public int ExecuteStrategy(params int[] numbers)
        {
            return _numbersStrategy?.Execute(numbers) ?? throw new NullReferenceException(nameof(_numbersStrategy));
        }
    }
}
