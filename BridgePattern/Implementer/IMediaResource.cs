using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern.Implementer
{
    internal interface IMediaResource
    {
        public void ShowSnippet();
        public void ShowTitle();
        public void ShowImage();
    }
}
