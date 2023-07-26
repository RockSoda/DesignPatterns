using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern.Subject
{
    internal class SubjectClass : ISubject
    {
        public SubjectClass(string arg) 
        { 
            //Expensive Operation
        }
        public void Request()
        {
            Console.WriteLine("Called Real Subject Instance");
        }
    }
}
