using Common.Interfaces.Validators;
using System;

namespace Common.Validators
{
    public class MinMaxValidator : IMinMaxValidator
    {
        private string _errorFormat = "{0} cannot be less then {1}.";
        private const string _defaultMinAlias = "Min";
        private const string _defaultMaxAlias = "Max";


        public void Validate(int min, int max, string minAlias = null, string maxAlias = null)
        {
            var errorMessage = string.Format(_errorFormat,
                                             minAlias ?? _defaultMinAlias,
                                             maxAlias ?? _defaultMaxAlias);

            if (min > max)
                throw new ArgumentException(errorMessage);
        }
    }
}
