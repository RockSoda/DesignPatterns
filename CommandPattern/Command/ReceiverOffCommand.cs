using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Command
{
    internal class ReceiverOffCommand : ICommand
    {
        Receiver _receiver;
        public ReceiverOffCommand(Receiver receiver)
        {
            _receiver = receiver;
        }
        public void Execute()
        {
            _receiver.Off();
        }

        public void Unexecute()
        {
            _receiver.On();
        }
    }
}
