using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Beverages
{
    internal class Espresso : Beverage
    {
        public override int GetCost()
        {
            return 1;
        }

        public override string GetDescription()
        {
            return "Espresso";
        }
    }
}
