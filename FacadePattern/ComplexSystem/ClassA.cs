using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern.ComplexSystem
{
    internal class ClassA
    {
        public ClassA(ClassB b) { }

        public void Display()
        {
            Console.WriteLine("ClassA");
        }
    }
}
