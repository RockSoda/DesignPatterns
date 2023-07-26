using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.Animal
{
    internal class Dog : IAnimal
    {
        public void Display()
        {
            Console.WriteLine("This is a Dog");
        }
    }
}
