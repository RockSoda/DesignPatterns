using IteratorPattern.Iterable;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern.Iterator
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
                _ => null,
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
