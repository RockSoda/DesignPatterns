using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommandPattern.Command;

namespace CommandPattern
{
    internal class Invoker
    {
        ICommand _on;
        ICommand _off;
        Stack<ICommand> _history;
        public Invoker(ICommand on, ICommand off) 
        {
            _on= on;
            _off= off;
            _history = new Stack<ICommand>();
        }

        public void ClickOn()
        {
            _on.Execute();
            _history.Push(_on);
        }

        public void ClickOff()
        {
            _off.Execute();
            _history.Push(_off);
        }

        public void Undo() 
        {
            if (_history.Count <= 0) return;

            var prevCommand = _history.Pop();
            prevCommand.Unexecute();
        }
    }
}
