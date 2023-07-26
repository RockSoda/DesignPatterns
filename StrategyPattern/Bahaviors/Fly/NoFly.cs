using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Bahaviors.Fly
{
    internal class NoFly : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("No Fly");
        }
    }
}
