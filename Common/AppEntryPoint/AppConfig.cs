using System;
using System.Collections.Generic;
using Common.Interfaces.Repositories;
using Common.Implementations.Repositories;
using Common.Implementations.Validators;
using Common.Interfaces.Validators;

namespace Common.AppEntryPoint
{
    [Obsolete("Temp realization!!!")]
    public static class AppConfig
    {
        public static IDictionary<Type, Type> GetRepositories()
        {
            return new Dictionary<Type, Type>
            {
                { typeof(IRandomIntRepository), typeof(StandartRandomIntRepository) },
                { typeof(IMinMaxValidator), typeof(MinMaxValidator) }
            };
        }
    }
}
