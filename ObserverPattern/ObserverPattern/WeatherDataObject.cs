using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern
{
    public class WeatherDataObject : IObservable<WeatherData>
    {
        List<IObserver<WeatherData>> observerMonitors;

        private float temperture;
        private float humidity;
        private float pressure;


        public WeatherDataObject()
        {
            observerMonitors = new List<IObserver<WeatherData>>();
        }

        public void NotifyObserver()
        {
            foreach (var observer in observerMonitors)
            {
                observer.Update(temperture, humidity, pressure);
            }
        }

        public void SetMeasurements(float temperture, float humidity, float pressure)
        {
            this.temperture = temperture;
            this.humidity = humidity;
            this.pressure = pressure;
        }

        public void MeasurementsChanged()
        {
            NotifyObserver();
        }

        public void RegisterObserver(IObserver<WeatherData> observer)
        {
            observerMonitors.Add(observer);
        }

        public void RemoveObserver(IObserver<WeatherData> observer)
        {
            observerMonitors.Remove(observer);
        }
    }
}
