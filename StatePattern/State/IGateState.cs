using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern.State
{
    internal interface IGateState
    {
        void PayFailed();
        void PayOK();
    }
}
