using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern.Implementer
{
    internal class ArtistResource : IMediaResource
    {
        public void ShowImage()
        {
            Console.WriteLine("Artist Image");
        }

        public void ShowSnippet()
        {
            Console.WriteLine("Artist Snippet");
        }

        public void ShowTitle()
        {
            Console.WriteLine("Artist Title");
        }
    }
}
