using FacadePattern.Facade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    internal class Client
    {
        FacadeInstance _facade;
        public Client() 
        {
            _facade = new FacadeInstance();
        }

        public void Request()
        {
            _facade.Display();
        }
    }
}
