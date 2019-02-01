using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern
{
    public class WeatherData
    {
        private float humidity;
        private float pressure;

        public WeatherData(double temperture, float humidity, float pressure)
        {
            this.Temperture = temperture;
            this.humidity = humidity;
            this.pressure = pressure;
        }

        public double Temperture { get; }

    }
}
