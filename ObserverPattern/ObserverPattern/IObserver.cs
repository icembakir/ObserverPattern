﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern
{
    public interface IObserver<T>
    {
        void Update(float temp, float humidity, float pressure);
    }
}
