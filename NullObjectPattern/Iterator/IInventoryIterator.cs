using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullObjectPattern.Iterator
{
    internal interface IInventoryIterator
    {
        bool IsDone();
        void Next();
        Item Current();
    }
}
