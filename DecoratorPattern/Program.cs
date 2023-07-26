using DecoratorPattern.Beverages;
using DecoratorPattern.Decorators;
using System;

namespace DecoratorPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var espresso = new Espresso();
            var darkroastWithCream = new CreamDecorator(new DarkRoast());
            var darkroastWithCreamWithMilk = new CreamDecorator(new MilkDecorator(new DarkRoast()));
            var espressoWithMilkWithCream = new MilkDecorator(new CreamDecorator(new Espresso()));

            Console.WriteLine("Description: {0} Cost: {1}", espresso.GetDescription(), espresso.GetCost());
            Console.WriteLine("Description: {0} Cost: {1}", darkroastWithCream.GetDescription(), darkroastWithCream.GetCost());
            Console.WriteLine("Description: {0} Cost: {1}", darkroastWithCreamWithMilk.GetDescription(), darkroastWithCreamWithMilk.GetCost());
            Console.WriteLine("Description: {0} Cost: {1}", espressoWithMilkWithCream.GetDescription(), espressoWithMilkWithCream.GetCost());
        }
    }
}
