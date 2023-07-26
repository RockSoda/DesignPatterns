using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    internal class Project : IToDoList
    {
        private string _title;
        private List<IToDoList> _toDos;
        public Project(string title, List<IToDoList> toDos) 
        {
            _title = title;
            _toDos = toDos;
        }
        public string GetHTML()
        {
            StringBuilder html = new StringBuilder("<ul><li>");
            html.Append(_title);
            html.Append("<ul>");
            foreach(var todo in _toDos)
            {
                html.Append("<li>");
                html.Append(todo.GetHTML());
                html.Append("</li>");
            }
            html.Append("</ul></li></ul>");
            return html.ToString();
        }
    }
}
