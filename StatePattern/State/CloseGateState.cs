using StatePattern.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern.State
{
    internal class CloseGateState : IGateState
    {
        Gate gate;
        public CloseGateState(Gate gate)
        {
            this.gate = gate;
        }

        public void PayFailed()
        {
            Console.WriteLine("You need to leave now");
            this.gate.ChangeState(new OpenGateState(this.gate));
        }

        public void PayOK()
        {
            Console.WriteLine("You are already in");
        }
    }
}
