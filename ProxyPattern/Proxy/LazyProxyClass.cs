using ProxyPattern.Subject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern.Proxy
{
    internal class LazyProxyClass : ISubject
    {
        private SubjectClass? realSubject;
        string _arg;
        public LazyProxyClass(string arg)
        {
            _arg= arg;
            realSubject = null;
        }

        public void Request()
        {
            if (realSubject == null) realSubject = new SubjectClass(_arg);
            realSubject.Request();
        }
    }
}
