using FactoryPattern.Animal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.Factory
{
    internal class RandomAnimalFactory : IAnimalFactory
    {
        Random _rng;
        public RandomAnimalFactory() 
        {
            _rng = new Random();
            Console.WriteLine("Entering Random Animal Factory");
        }
        public IAnimal CreateAnimal()
        {
            var rnd = _rng.Next(3);

            return rnd switch
            {
                0 => new Cat(),
                1 => new Dog(),
                2 => new Duck(),
                _ => throw new NotImplementedException()
            };
        }
    }
}
