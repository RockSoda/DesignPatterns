using SingletonPattern.Singleton;

namespace SingletonPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SingletonClass.GetSingletonInstance();
            SingletonClass.GetSingletonInstance();
        }
    }
}