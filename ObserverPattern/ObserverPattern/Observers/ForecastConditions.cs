using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern.Observers
{
    public class ForecastConditions : IDisplay, IObserver<WeatherData>
    {
        private float temperture;
        private float humidity;
        private float pressure;
        private IObservable<WeatherData> observable;

        public ForecastConditions(IObservable<WeatherData> observable)
        {
            this.observable = observable;
            observable.RegisterObserver(this);
        }

        public void Display()
        {
            Console.WriteLine(temperture + humidity + pressure);
        }

        public void Update(float temp, float humidity, float pressure)
        {
            temperture = temp;
            this.humidity = humidity;
            this.pressure = pressure;
            Display();
        }
    }
}
