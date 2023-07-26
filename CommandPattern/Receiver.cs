using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    internal class Receiver
    {
        public void On()
        {
            Console.WriteLine("ON");
        }
        public void Off()
        {
            Console.WriteLine("OFF");
        }
    }
}
