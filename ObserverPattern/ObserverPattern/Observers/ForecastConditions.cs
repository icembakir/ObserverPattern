using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern.Observers
{
    public class ForecastConditions : IDisplay, IObserver<WeatherData>
    {
        private float temperture;
        private float humidity;
        private IObservable<WeatherData> weatherData;

        public ForecastConditions(IObservable<WeatherData> weatherData)
        {
            this.weatherData = weatherData;
            weatherData.RegisterObserver(this);
        }
        public string Display()
        {
            throw new NotImplementedException();
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }
}
