using AbstractFactoryPattern.AbstractFacotry;

namespace AbstractFactoryPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var concreteFactory1 = new Factory1();

            concreteFactory1.GetProductA().Display();
            concreteFactory1.GetProductB().Display();

            var concreteFactory2 = new Factory2();

            concreteFactory2.GetProductA().Display();
            concreteFactory2.GetProductB().Display();
        }
    }
}