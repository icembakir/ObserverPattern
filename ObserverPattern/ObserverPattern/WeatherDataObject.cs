using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern
{
    public class WeatherDataObject : IObservable<WeatherData>
    {
        List<IObserver<WeatherData>> observerMonitors;

        public WeatherDataObject()
        {
            observerMonitors = new List<IObserver<WeatherData>>();
        }

        public void NotifyObserver()
        {
            throw new NotImplementedException();
        }

        public void RegisterObserver()
        {
            throw new NotImplementedException();
        }

        public void RemoveObserver()
        {
            throw new NotImplementedException();
        }
    }
}
