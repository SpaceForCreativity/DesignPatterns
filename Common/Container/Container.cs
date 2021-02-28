using Common.AppEntryPoint;
using System;
using System.Collections.Generic;

namespace Common.Container
{
    [Obsolete("Temp realization!!!")]
    public static class Container
    {
        private static Dictionary<Type, object> _implementationsByInterfaces = new Dictionary<Type, object>();
        private static object _locker = new object();


        static Container()
        {
            foreach (var classByInterface in AppConfig.GetRepositories())
            {
                Register(classByInterface.Key, classByInterface.Value);
            }
        }


        public static T Resolve<T>()
        {
            return (T)_implementationsByInterfaces[typeof(T)];
        }

        public static void Register<TInterface, TRealization>()
            where TRealization : new()
        {
            lock(_locker)
            {
                _implementationsByInterfaces.Add(typeof(TInterface), new TRealization());
            }
        }
        

        private static void Register(Type @interface, Type realization)
        {
            lock(_locker)
            {
                var instance = Activator.CreateInstance(realization);
                _implementationsByInterfaces.Add(@interface, instance);
            }
        }
    }
}
