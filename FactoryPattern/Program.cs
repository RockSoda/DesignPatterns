using FactoryPattern.Factory;

namespace FactoryPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IAnimalFactory animalFactory;

            var rng = new Random();

            animalFactory = rng.Next(2) == 0 ? new BalancedAnimalFactory() : new RandomAnimalFactory();

            for (int i = 0; i < 6; i++)
                animalFactory.CreateAnimal().Display();

        }
    }
}
