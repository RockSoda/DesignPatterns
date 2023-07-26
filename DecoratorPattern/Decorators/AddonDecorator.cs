using DecoratorPattern.Beverages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Decorators
{
    internal abstract class AddonDecorator : Beverage 
    {
        public AddonDecorator(Beverage beverage) { }
    }
}
