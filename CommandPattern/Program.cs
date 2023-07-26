using CommandPattern.Command;

namespace CommandPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var receiver = new Receiver();
            var invoker = new Invoker(new ReceiverOnCommand(receiver), new ReceiverOffCommand(receiver));
            invoker.ClickOn();
            invoker.ClickOff();
            invoker.Undo();
        }
    }
}