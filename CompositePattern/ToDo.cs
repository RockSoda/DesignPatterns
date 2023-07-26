using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    internal class ToDo : IToDoList
    {
        private string _text;
        public ToDo(string text) 
        {
            _text = text;
        }
        public string GetHTML()
        {
            return _text;
        }
    }
}
