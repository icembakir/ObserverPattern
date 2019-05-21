using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern
{
    public interface IObservable<T>
    {
        void RegisterObserver(IObserver<T> observer);
        void RemoveObserver(IObserver<T> observer);
        void NotifyObserver();
    }
}
