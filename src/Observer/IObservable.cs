﻿using System;
namespace Observer
{
    public interface IObservable
    {
        void Subscribe(IObserver observer);

        void Unsubscribe(IObserver observer);

        void NotifyObservers(Message message);


    }
}
