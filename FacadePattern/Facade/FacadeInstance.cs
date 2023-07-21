using FacadePattern.ComplexSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern.Facade
{
    internal class FacadeInstance
    {
        ClassA _a;
        ClassB _b;
        public FacadeInstance()
        {
            _a = new ClassA(_b);
            _b = new ClassB(_a);
        }

        public void Display()
        {
            _a.Display();
            _b.Display();
        }
    }
}
