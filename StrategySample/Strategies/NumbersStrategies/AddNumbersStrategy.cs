using StrategyPattern.Strategies.Interfaces;
using System.Linq;

namespace StrategyPattern.Strategies.NumbersStrategies
{
    public class AddNumbersStrategy : INumbersStrategy
    {
        public int Execute(params int[] numbers)
        {
            return numbers.Sum();
        }
    }
}
