using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Bahaviors.Fly
{
    internal class JetFly : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("Jet Fly");
        }
    }
}
