using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.Animal
{
    internal class Cat : IAnimal
    {
        public void Display()
        {
            Console.WriteLine("This is a Cat");
        }
    }
}
