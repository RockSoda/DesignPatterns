using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Command
{
    internal class ReceiverOnCommand : ICommand
    {
        Receiver _receiver;
        public ReceiverOnCommand(Receiver receiver)
        {
            _receiver = receiver;
        }
        public void Execute()
        {
            _receiver.On();
        }

        public void Unexecute()
        {
            _receiver.Off();
        }
    }
}
