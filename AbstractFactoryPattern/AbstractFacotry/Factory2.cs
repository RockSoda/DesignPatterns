using AbstractFactoryPattern.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern.AbstractFacotry
{
    internal class Factory2 : IFactory
    {
        public Factory2()
        {
            Console.WriteLine("Entering Factory 2");
        }
        public IProductA GetProductA()
        {
            return new ProductA2();
        }

        public IProductB GetProductB()
        {
            return new ProductB2();
        }
    }
}
