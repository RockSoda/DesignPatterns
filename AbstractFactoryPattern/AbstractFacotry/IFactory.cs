using AbstractFactoryPattern.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern.AbstractFacotry
{
    internal interface IFactory
    {
        IProductA GetProductA();
        IProductB GetProductB();
    }
}
