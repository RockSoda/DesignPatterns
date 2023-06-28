namespace ObserverPattern
{
    public class Program
    {
        public static void Main()
        {
            var observable = new Observable.ObservableStation();

            var display1 = new Observer.ObserverInstance(observable, "Observer1");
            var display2 = new Observer.ObserverInstance(observable, "Observer2");

            observable.Add(display1);
            observable.Add(display2);

            observable.Notify();

            display1.Display();
            display2.Display();
        }
    }
}