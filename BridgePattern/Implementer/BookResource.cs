using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern.Implementer
{
    internal class BookResource : IMediaResource
    {
        public void ShowImage()
        {
            Console.WriteLine("Book Image");
        }

        public void ShowSnippet()
        {
            Console.WriteLine("Book Snippet");
        }

        public void ShowTitle()
        {
            Console.WriteLine("Book Title");
        }
    }
}
