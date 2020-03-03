using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using SensorMiddlewareSerial.Data;

namespace SensorMiddlewareSerial.Manager
{
    public static class DeviceManager
    {
        public static DeviceList Devices = new DeviceList();

        /// <summary>
        /// Looks for new devices async
        /// </summary>
        public static void LookForNewDevicesAsync()
        {
            //var found = false;
            //while (!found)
            //{
            //    Console.WriteLine("INFO > Looking for new devices");

            //    const string unwantedPort = "/dev/ttyAMA0";

            //    var newDevices = SerialPort.GetPortNames()
            //        .Where(port => port != unwantedPort && !Devices.IsDeviceKnown(port)).ToList();

            //    Console.WriteLine(newDevices.Count);

            //    if (!newDevices.Any())
            //        continue;

            //    found = true;

            //    AddNewDevices(newDevices);
            //}
            Devices.Add("", Utility.Sensor.Force);
        }

        /// <summary>
        /// Adds found devices
        /// </summary>
        public static void AddNewDevices(List<string> ports)
        {
            ports.ForEach(port => Console.WriteLine($"INFO > Found {port}"));
            ports.ForEach(AddNewDevice);
        }

        /// <summary>
        /// Adds new device
        /// </summary>
        public static void AddNewDevice(string port)
        {
            //var serialPort = new SerialPort(port, Keys.BaudRate, Parity.Mark);
            //try
            //{
            //    serialPort.Open();
            //}
            //catch (Exception)
            //{
            //    Console.Error.WriteLine("Failed to bind new device");
            //    return;
            //}

            var sensorType = Utility.Sensor.Undefined;

            //while (sensorType == Utility.Sensor.Undefined)
            //{
            //    var result = serialPort.ReadLine();

            //    if (!int.TryParse(result, out var sensorResult))
            //        continue;

            //    if (Enum.IsDefined(typeof(Utility.Sensor), sensorResult))
            //        sensorType = (Utility.Sensor)sensorResult;
            //}

            //serialPort.WriteLine("OK"); //TODO: sinnvolle antwort

            //serialPort.Close();

            Devices.Add(port, sensorType);

        }
    }
}
