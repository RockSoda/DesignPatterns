using StatePattern.State;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern.Context
{
    internal class Gate
    {
        IGateState state;

        public Gate()
        {
            this.state= new OpenGateState(this);
        }
        public void PayOK()
        {
            this.state.PayOK();
        }
        public void PayFailed()
        {
            this.state.PayFailed();
        }
        public void ChangeState(IGateState gateState) 
        {
            this.state = gateState;
        }
    }
}
