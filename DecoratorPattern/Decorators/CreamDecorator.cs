using DecoratorPattern.Beverages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Decorators
{
    internal class CreamDecorator : AddonDecorator
    {
        private readonly Beverage _beverage;
        public CreamDecorator(Beverage beverage) : base(beverage)
        {
            _beverage = beverage;
        }
        public override int GetCost()
        {
            return _beverage.GetCost() + 2;
        }

        public override string GetDescription()
        {
            return _beverage.GetDescription() + " with Cream";
        }
    }
}
