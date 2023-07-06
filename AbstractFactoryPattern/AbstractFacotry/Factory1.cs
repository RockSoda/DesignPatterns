using AbstractFactoryPattern.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern.AbstractFacotry
{
    internal class Factory1 : IFactory
    {
        public Factory1() 
        {
            Console.WriteLine("Entering Factory 1");
        }
        public IProductA GetProductA()
        {
            return new ProductA1();
        }

        public IProductB GetProductB()
        {
            return new ProductB1();
        }
    }
}
