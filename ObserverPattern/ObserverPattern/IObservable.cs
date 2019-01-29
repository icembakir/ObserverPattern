using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern
{
    public interface IObservable<T>
    {
        void RegisterObserver(IObserver<WeatherData> observer);
        void RemoveObserver(IObserver<WeatherData> observer);
        void NotifyObserver();
    }
}
