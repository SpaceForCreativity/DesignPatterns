using StrategyPattern.Strategies.Interfaces;
using System.Linq;

namespace StrategyPattern.Strategies.NumbersStrategies
{
    public class MultiplyNumbersStrategy : INumbersStrategy
    {
        public int Execute(params int[] numbers)
        {
            if (numbers == null || !numbers.Any())
                return 0;
            else
                return numbers.Aggregate((a, b) => a * b);
        }
    }
}
