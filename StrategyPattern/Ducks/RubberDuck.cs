using ConsoleApp1.Bahaviors.Fly;
using ConsoleApp1.Bahaviors.Quack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Ducks
{
    internal class RubberDuck : Duck
    {
        public RubberDuck() : base(new NoQuack(), new NoFly()) { }
    }
}
