using StrategySample.Repositories.Interfaces;
using StrategySample.Validators;
using System;
using System.Collections.Generic;

namespace StrategySample.Repositories.RandomIntRepositories
{
    public class StandartRandomIntRepository : IRandomIntRepository
    {
        private Random _random = new Random(Guid.NewGuid().GetHashCode());
        private MinMaxValidator _minMaxValidator = new MinMaxValidator();

        public IEnumerable<int> GetRandomValues(int minNumber, int maxNumber, int count)
        {
            if (count < 0)
                throw new ArgumentException("Count cannot be less then 0.");

            _minMaxValidator.Validate(minNumber, maxNumber, nameof(minNumber), nameof(maxNumber));

            for (int i = 0; i < count; i++)
            {
                yield return _random.Next(minNumber, maxNumber);
            }
        }

        public IEnumerable<int> GetRandomValuesRandomCount(int minNumber, int maxNumber, int minCount, int maxCount)
        {
            if (minCount < 0 || maxCount < 0)
                throw new ArgumentException("Count cannot be less then 0.");

            _minMaxValidator.Validate(minNumber, maxNumber, nameof(minNumber), nameof(maxNumber));
            _minMaxValidator.Validate(minCount, maxCount, nameof(minCount), nameof(maxCount));

            int count = _random.Next(minCount, maxCount);

            for (int i = 0; i < count; i++)
            {
                yield return _random.Next(minNumber, maxNumber);
            }
        }
    }
}
