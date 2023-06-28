using ObserverPattern.Observer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Observable
{
    internal interface IObservable
    {
        public void Add(IObserver observer);
        public void Remove(IObserver observer);
        public abstract void Notify();
    }
}
