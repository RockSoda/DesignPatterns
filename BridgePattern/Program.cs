using BridgePattern.Abstraction;
using BridgePattern.Implementer;

namespace BridgePattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IMediaResource artist = new ArtistResource();
            IMediaResource book = new BookResource();
            IView longView = new LongFormView(); 
            IView shortView = new ShortFormView();

            longView.Show(artist);
            longView.Show(book);
            shortView.Show(artist);
            shortView.Show(book);
        }
    }
}