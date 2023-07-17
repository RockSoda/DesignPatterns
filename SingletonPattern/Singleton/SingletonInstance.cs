using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern.Singleton
{
    internal class SingletonInstance
    {
        private static SingletonInstance _singletonInstance;
        private SingletonInstance() { }
        public static SingletonInstance GetSingletonInstance()
        {
            if (_singletonInstance == null)
            {
                _singletonInstance = new SingletonInstance();
                Console.WriteLine("Singleton Instance Created!");
            }
            else
                Console.WriteLine("Reusing Singleton Instance!");


            return _singletonInstance;
        }
    }
}
