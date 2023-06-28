using DecoratorPattern.Beverages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Decorators
{
    internal class MilkDecorator : AddonDecorator
    {
        private readonly Beverage _beverage;
        public MilkDecorator(Beverage beverage) : base(beverage)
        {
            _beverage = beverage;
        }

        public override int GetCost()
        {
            return _beverage.GetCost() + 1;
        }

        public override string GetDescription()
        {
            return _beverage.GetDescription() + " with Milk";
        }
    }
}
