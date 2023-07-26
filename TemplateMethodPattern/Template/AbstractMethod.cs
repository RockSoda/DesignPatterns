using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodPattern.Template
{
    internal abstract class AbstractMethod
    {
        public void TemplateMethod()
        {
            Console.WriteLine("Entering Template Method");
            Operation1();
            Operation2();
        }

        public abstract void Operation1();
        public abstract void Operation2();
    }
}
