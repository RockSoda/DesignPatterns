using IteratorPattern.Iterator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern.Iterable
{
    internal class HandheldInventory : IInventory
    {
        public Item Right { get; private set; }
        public Item Left { get; private set; }

        public HandheldInventory(Item right, Item left)
        {
            this.Right = right;
            this.Left = left;
        }

        public IInventoryIterator GetIterator()
        {
            return new HandheldInventoryIterator(this);
        }
    }
}
