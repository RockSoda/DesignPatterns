using ConsoleApp1.Bahaviors.Fly;
using ConsoleApp1.Bahaviors.Quack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Ducks
{
    internal class WildDuck : Duck
    {
        public WildDuck() : base(new SimpleQuack(), new JetFly()) { }
    }
}
