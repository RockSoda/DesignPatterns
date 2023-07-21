using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern.ComplexSystem
{
    internal class ClassB
    {
        public ClassB(ClassA a) { }

        public void Display() 
        {
            Console.WriteLine("ClassB");
        }
    }
}
