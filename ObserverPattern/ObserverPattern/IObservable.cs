using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern
{
    public interface IObservable<T>
    {
        void RegisterObserver();
        void RemoveObserver();
        void NotifyObserver();
    }
}
