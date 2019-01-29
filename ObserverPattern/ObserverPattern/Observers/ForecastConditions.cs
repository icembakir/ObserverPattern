using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern.Observers
{
    public class ForecastConditions : IDisplay, IObserver<T>
    {
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
