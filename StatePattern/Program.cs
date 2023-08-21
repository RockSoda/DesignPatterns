using StatePattern.Context;
using StatePattern.State;

namespace StatePattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Gate gate = new Gate();
            gate.PayFailed();
            gate.PayOK();
            gate.PayOK();
            gate.PayFailed();
        }
    }
}