using BridgePattern.Implementer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern.Abstraction
{
    internal class ShortFormView : IView
    {
        public void Show(IMediaResource mediaResource)
        {
            mediaResource.ShowSnippet();
            mediaResource.ShowTitle();
        }
    }
}
