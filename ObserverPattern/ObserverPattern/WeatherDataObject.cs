using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern
{
    public class WeatherDataObject : IObservable<WeatherData>
    {
        List<IObserver<WeatherData>> observers;

        public WeatherDataObject()
        {
            observers = new List<IObserver<WeatherData>>();
        }

        public void NotifyObserver()
        {
            throw new NotImplementedException();
        }

        public void RegisterObserver(IObserver<WeatherData> o)
        {
            observers.Add(o);
        }
        
        public void RemoveObserver(IObserver<WeatherData> observer)
        {
            throw new NotImplementedException();
        }
    }
}
