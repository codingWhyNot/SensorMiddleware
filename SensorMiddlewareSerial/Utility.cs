using System;
using System.Collections.Generic;
using System.Text;

namespace SensorMiddlewareSerial
{
    public static class Utility
    {
        public enum Sensor
        {
            Undefined = -1,
            Volume = 0,
            Thermal = 1,
            Force = 2
        }
    }
}
