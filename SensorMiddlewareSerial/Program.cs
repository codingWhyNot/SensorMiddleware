using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Threading.Tasks;
using SensorMiddlewareSerial.Manager;

namespace SensorMiddlewareSerial
{
    class Program
    {
        static void Main(string[] args)
        {
            DeviceManager.LookForNewDevicesAsync();
            Console.ReadKey();
        }
    }
}
