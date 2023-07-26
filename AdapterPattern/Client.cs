using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdapterPattern.Adapt;

namespace AdapterPattern
{
    internal class Client
    {
        ITarget _target;
        public Client() 
        {
            _target = new Adapter(new Adaptee());
        }

        public void Request()
        {
            _target.Request();
        }
    }
}
