using IteratorPattern.Iterable;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern
{
    internal class Client
    {
        IInventory HandheldInv;

        public Client()
        {
            HandheldInv = new HandheldInventory(new Item("Left"), new Item("Right"));
        }

        public void Execute()
        {
            var iterator = HandheldInv.GetIterator();
            while(!iterator.IsDone())
            {
                iterator.Current().Display();
                iterator.Next();
            }
        }
    }
}
