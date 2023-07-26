using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TemplateMethodPattern.Template;

namespace TemplateMethodPattern
{
    internal class ConcreteMethod : AbstractMethod
    {
        public override void Operation1()
        {
            Console.WriteLine("Method Instance Operation 1");
        }

        public override void Operation2()
        {
            Console.WriteLine("Method Instance Operation 2");
        }
    }
}
