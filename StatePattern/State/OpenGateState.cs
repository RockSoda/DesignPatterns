using StatePattern.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern.State
{
    internal class OpenGateState : IGateState
    {
        Gate gate;
        public OpenGateState(Gate gate) 
        {
            this.gate = gate;
        }
        public void PayFailed()
        {
            Console.WriteLine("Do not let user in");
        }

        public void PayOK()
        {
            Console.WriteLine("Let user in");
            this.gate.ChangeState(new CloseGateState(this.gate));
        }
    }
}
