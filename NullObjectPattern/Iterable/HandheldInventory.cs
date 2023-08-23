using NullObjectPattern.Iterator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullObjectPattern.Iterable
{
    internal class HandheldInventory : IInventory
    {
        public Item Right { get; private set; }
        public Item Left { get; private set; }
        public Item NullItem { get; private set; }

        public HandheldInventory(Item right, Item left)
        {
            this.Right = right;
            this.Left = left;
            this.NullItem = new Item("Null Item");
        }

        public IInventoryIterator GetIterator()
        {
            return new HandheldInventoryIterator(this);
        }
    }
}
