using ProxyPattern.Proxy;

namespace ProxyPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var proxy = new LazyProxyClass("");
            proxy.Request();
        }
    }
}