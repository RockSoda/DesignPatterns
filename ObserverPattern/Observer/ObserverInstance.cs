using ObserverPattern.Observable;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Observer
{
    internal class ObserverInstance : IObserver, IDisplay
    {
        readonly ObservableStation _observable;
        string Name { get; set; }
        public ObserverInstance(ObservableStation observable, string name) 
        {
            _observable = observable;
            Name = name;
        }
        public void Update()
        {
            Console.WriteLine("Updating " + Name + ", new data = " + _observable.Data);
        }
        public void Display()
        {
            Console.WriteLine("This is " + Name);
        }
    }
}
