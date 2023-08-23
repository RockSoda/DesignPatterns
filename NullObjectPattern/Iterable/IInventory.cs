using NullObjectPattern.Iterator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullObjectPattern.Iterable
{
    internal interface IInventory
    {
        public IInventoryIterator GetIterator();
    }
}
