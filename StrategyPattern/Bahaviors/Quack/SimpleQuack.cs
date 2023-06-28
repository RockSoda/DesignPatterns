using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Bahaviors.Quack
{
    internal class SimpleQuack : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("Simple Quack");
        }
    }
}
