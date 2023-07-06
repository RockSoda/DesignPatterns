﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern.Product
{
    internal class ProductB1 : IProductB
    {
        public void Display()
        {
            Console.WriteLine("This is a Product of B1");
        }
    }
}
