using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern
{
    public class WeatherData
    {
        public WeatherData(double temperture, float humidity, float pressure)
        {
            this.Temperture = temperture;
            this.Humidity = humidity;
            this.Pressure = pressure;
        }

        public double Temperture { get; }

        public float Humidity { get; }

        public float Pressure { get; }


    }
}
