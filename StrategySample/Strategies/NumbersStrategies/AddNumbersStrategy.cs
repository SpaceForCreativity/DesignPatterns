using StrategySample.Strategies.Interfaces;
using System.Linq;

namespace StrategySample.Strategies.NumbersStrategies
{
    public class AddNumbersStrategy : INumbersStrategy
    {
        public int Execute(params int[] numbers)
        {
            return numbers.Sum();
        }
    }
}
