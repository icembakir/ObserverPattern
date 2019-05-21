using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern
{
    public class WeatherData
    {
        private float humidity;
        private float pressure;
        private float temperture;

        public WeatherData(float temperture, float humidity, float pressure)
        {
            this.temperture = temperture;
            this.humidity = humidity;
            this.pressure = pressure;
        }

        
    }
}
