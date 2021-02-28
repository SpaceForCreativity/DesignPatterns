using System.Collections.Generic;

namespace StrategyPattern.Repositories.Interfaces
{
    public interface IRandomIntRepository
    {
        IEnumerable<int> GetRandomValues(int minNumber, int maxNumber, int count);
        IEnumerable<int> GetRandomValuesRandomCount(int minNumber, int maxNumber, int minCount, int maxCount);
    }
}
