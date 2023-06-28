using ObserverPattern.Observer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Observable
{
    internal class ObservableStation : IObservable
    {
        private readonly List<IObserver> _observers;
        public int Data { get; set; }
        public ObservableStation() 
        {
            _observers = new List<IObserver>();
        }
        public void Add(IObserver observer) 
        {
            _observers.Add(observer);
        }
        public void Remove(IObserver observer)
        {
            _observers.Remove(observer);
        }
        public void Notify()
        {
            FetchData(100);
            foreach (var observer in _observers)
                observer.Update();
        }

        private void FetchData(int data)
        {
            Data= data;
        }
    }
}
