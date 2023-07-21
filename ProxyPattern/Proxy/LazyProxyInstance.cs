using ProxyPattern.Subject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern.Proxy
{
    internal class LazyProxyInstance : ISubject
    {
        private SubjectInstance? realSubject;
        string _arg;
        public LazyProxyInstance(string arg)
        {
            _arg= arg;
            realSubject = null;
        }

        public void Request()
        {
            if (realSubject == null) realSubject = new SubjectInstance(_arg);
            realSubject.Request();
        }
    }
}
