using FactoryPattern.Animal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.Factory
{
    internal class BalancedAnimalFactory : IAnimalFactory
    {
        Random _rng;
        List<IAnimal> _animals;
        public BalancedAnimalFactory()
        {
            _rng = new Random();
            _animals = new List<IAnimal> { new Cat(), new Dog(), new Duck()};
            Console.WriteLine("Entering Balanced Animal Factory");
        }
        public IAnimal CreateAnimal()
        {
            if(_animals.Count == 0)
                _animals = new List<IAnimal> { new Cat(), new Dog(), new Duck() };

            var idx = _rng.Next(_animals.Count);

            var animal = _animals[idx];

            _animals.RemoveAt(idx);

            return animal;
        }
    }
}
