using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern.Singleton
{
    internal class SingletonClass
    {
        private static SingletonClass _singletonInstance;
        private SingletonClass() { }
        public static SingletonClass GetSingletonInstance()
        {
            if (_singletonInstance == null)
            {
                _singletonInstance = new SingletonClass();
                Console.WriteLine("Singleton Instance Created!");
            }
            else
                Console.WriteLine("Reusing Singleton Instance!");

            return _singletonInstance;
        }
    }
}
