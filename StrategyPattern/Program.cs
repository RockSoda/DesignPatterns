using ConsoleApp1.Bahaviors.Fly;
using ConsoleApp1.Bahaviors.Quack;
using ConsoleApp1.Ducks;

namespace StrategyPattern
{
    public class Program
    {
        public static void Main()
        {
            var cityDuck = new CityDuck();
            var wildDuck = new WildDuck();
            var rubberDuck = new RubberDuck();
            var testDuck = new Duck(new NoQuack(), new JetFly());

            cityDuck.Quack();
            wildDuck.Quack();
            rubberDuck.Quack();

            cityDuck.Fly();
            wildDuck.Fly();
            rubberDuck.Fly();

            cityDuck.display();
            wildDuck.display();
            rubberDuck.display();
        }
    }
}