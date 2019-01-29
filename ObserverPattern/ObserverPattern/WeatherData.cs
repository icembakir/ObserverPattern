using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern
{
    public class WeatherData
    {
        private double temperture;
        private float humidity;
        private float pressure;

        public WeatherData(double temperture, float humidity, float pressure)
        {
            this.temperture = temperture;
            this.humidity = humidity;
            this.pressure = pressure;
        }

        public double Temperture
        {
            get { return this.temperture; }
        }

       
    }
}
