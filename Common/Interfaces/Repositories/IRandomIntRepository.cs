using System.Collections.Generic;

namespace Common.Interfaces.Repositories
{
    public interface IRandomIntRepository
    {
        IEnumerable<int> GetRandomValues(int minNumber, int maxNumber, int count);
        IEnumerable<int> GetRandomValuesRandomCount(int minNumber, int maxNumber, int minCount, int maxCount);
    }
}
