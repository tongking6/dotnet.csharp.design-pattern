using System;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            var observer1 = new Observer("George");
            var observer2 = new Observer("Eric");
            var observable = new Observable();

            observable.Subscribe(observer1);
            observable.Subscribe(observer2);

            observable.NotifyObservers(new Message("Hello World"));
            Console.WriteLine("");

            observable.Unsubscribe(observer1);
            observable.NotifyObservers(new Message("Goodbye World"));
        }
    }
}
