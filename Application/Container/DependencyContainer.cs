using Common.Generators;
using Common.Interfaces.Generators;
using Common.Interfaces.Validators;
using Common.Validators;
using System;
using System.Collections.Generic;

namespace Application.Container
{
    public static class DependencyContainer
    {
        private static IDictionary<Type, object> _dependencies;


        static DependencyContainer()
        {
            _dependencies = new Dictionary<Type, object>();

            //TODO: move this out.
            Register<IMinMaxValidator, MinMaxValidator>();
            var validator = Resolve<IMinMaxValidator>();
            Register<IRandomIntGenerator, StandartRandomIntGenerator>(validator);
        }

        public static void Register<T1, T2>(params object[] args)
            where T1 : class
            where T2 : class
        {

            var instance = Activator.CreateInstance(typeof(T2), args);
            _dependencies.Add(typeof(T1), instance);
        }

        public static T Resolve<T>()
            where T : class
        {
            return _dependencies.TryGetValue(typeof(T), out var value) ? (T)value : null;
        }
    }
}
