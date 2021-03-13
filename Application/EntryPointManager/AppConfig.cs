using Common.Generators;
using Common.Interfaces.Generators;
using Common.Interfaces.Validators;
using Common.Validators;
using System;
using System.Collections.Generic;

namespace Application.EntryPointManager
{
    [Obsolete("Temp realization!!!")]
    public static class AppConfig
    {
        public static IDictionary<Type, Type> GetRepositories()
        {
            return new Dictionary<Type, Type>
            {
                { typeof(IRandomIntGenerator), typeof(StandartRandomIntGenerator) },
                { typeof(IMinMaxValidator), typeof(MinMaxValidator) }
            };
        }
    }
}
