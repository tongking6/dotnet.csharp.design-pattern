namespace Observer
{
    using System;
    using System.Collections.Generic;

    public class Observable : IObservable
    {
        private List<IObserver> observerList;


        public Observable()
        {
            this.observerList = new List<IObserver>();
        }

        public void Subscribe(IObserver observer)
        {
            Console.WriteLine($"Observer {observer.Id} subscribed");
            observerList.Add(observer);
        }

        public void Unsubscribe(IObserver observer)
        {
            Console.WriteLine($"Observer {observer.Id} unsubscribed");
            observerList.Remove(observer);
        }

        public void NotifyObservers(Message message)
        {
            Console.WriteLine("--------NOTIFY SUBSCRIBERS--------");
            foreach(var observer in observerList)
            {
                observer.update(message);
            }
        }


    }
}
