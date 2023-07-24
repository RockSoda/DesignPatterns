using BridgePattern.Implementer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern.Abstraction
{
    internal interface IView
    {
        public abstract void Show(IMediaResource mediaResource);
    }
}
