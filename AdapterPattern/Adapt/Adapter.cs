﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern.Adapt
{
    internal class Adapter : ITarget
    {
        private Adaptee _adaptee;
        public Adapter(Adaptee adaptee)
        {
            _adaptee = adaptee;
        }
        public void Request()
        {
            _adaptee.SpecificRequest();
        }
    }
}
