using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Text;
using SensorMiddlewareSerial.Manager;

namespace SensorMiddlewareSerial.Data
{
    public class DeviceList
    {
        public List<Device> Devices = new List<Device>();

        public bool IsDeviceKnown(string port)
        {
            return Devices.Exists(e => e.SerialPort == port);
        }

        public void Add(string port, Utility.Sensor sensorType)
        {
            Console.WriteLine($"INFO > Added new {sensorType.ToString()} sensor on port {port}");

            var device = new Device
            {
                SensorType = sensorType,
                SerialPort = port
            };

            Devices.Add(device);

            device.StartListening();
        }
    }
}
