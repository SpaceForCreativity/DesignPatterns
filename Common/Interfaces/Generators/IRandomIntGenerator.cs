using System.Collections.Generic;

namespace Common.Interfaces.Generators
{
    public interface IRandomIntGenerator
    {
        IEnumerable<int> GetRandomValues(int minNumber, int maxNumber, int count);
        IEnumerable<int> GetRandomValuesRandomCount(int minNumber, int maxNumber, int minCount, int maxCount);
    }
}