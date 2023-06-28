using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Beverages
{
    internal class DarkRoast : Beverage
    {
        public override int GetCost()
        {
            return 2;
        }

        public override string GetDescription()
        {
            return "Dark Roast";
        }
    }
}
