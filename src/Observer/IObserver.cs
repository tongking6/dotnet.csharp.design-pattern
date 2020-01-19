using System;
namespace Observer
{
    public interface IObserver
    {
        void update(Message message);

        string Id { get; }
    }
}
