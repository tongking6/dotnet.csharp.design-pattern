using System;
namespace Observer
{
    public class Observer : IObserver
    {
        public string Id { get; }

        public Observer(string id)
        {
            this.Id = id;
        }

        public void update(Message message)
        {
            Console.WriteLine($"Observer {Id} received message: {message.Content}");
        }
    }
}
