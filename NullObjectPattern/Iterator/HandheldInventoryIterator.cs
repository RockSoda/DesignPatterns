using NullObjectPattern.Iterable;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace NullObjectPattern.Iterator
{
    internal class HandheldInventoryIterator : IInventoryIterator
    {
        HandheldInventory Inventory;
        int index;
        public HandheldInventoryIterator(HandheldInventory handheldInventory)
        {
            index = 0;
            Inventory = handheldInventory;
        }
        public Item Current()
        {
            return index switch
            {
                0 => Inventory.Right,
                1 => Inventory.Left,
                _ => Inventory.NullItem,
            };
        }

        public bool IsDone()
        {
            return index >= 2;
        }

        public void Next()
        {
            index++;
        }
    }
}
