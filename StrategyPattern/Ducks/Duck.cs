using ConsoleApp1.Bahaviors.Fly;
using ConsoleApp1.Bahaviors.Quack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Ducks
{
    internal class Duck
    {
        private readonly IQuackBehavior _quackBehavior;
        private readonly IFlyBehavior _flyBehavior;
        
        public Duck(IQuackBehavior quackBehavior, IFlyBehavior flyBehavior)
        {
            _quackBehavior = quackBehavior;
            _flyBehavior = flyBehavior;
        }

        public void Quack() 
        {
            _quackBehavior.Quack();
        }
        public void Fly() 
        {
            _flyBehavior.Fly();
        }
        public void display()
        {
            Console.WriteLine("This is a duck");
        }
    }
}
