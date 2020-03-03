using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO.Ports;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using SensorMiddlewareSerial.Data;

namespace SensorMiddlewareSerial.Manager
{
    public static class DataManager
    {
        /// <summary>
        /// Starts listening to the port
        /// </summary>
        public static void StartListening(this Device device)
        {
            //await Task.Run(() =>
            //{

            //    var port = new SerialPort(device.SerialPort, Keys.BaudRate);

            //    Thread.Sleep(1500);

            //    try
            //    {
            //        port.Open();
            //    }
            //    catch (Exception e)
            //    {
            //        Console.WriteLine(e);
            //        return;
            //    }


            //    Console.WriteLine("INFO > Start listening on port " + port.PortName);

            //    for (int i = 0; i < 100000; i++)
            //    {
            //        try
            //        {
            //            port.ReadLine();
            //        }
            //        catch (Exception e)
            //        {
            //            Console.WriteLine(e);

            //        }

            //    }

            //    Console.WriteLine(100000);
            //});

            var process = new Process()
            {
                StartInfo = new ProcessStartInfo()
                {
                    FileName = Keys.PythonPath,
                    Arguments = Keys.ReadUsbPyPath,
                    CreateNoWindow = true,
                    RedirectStandardError = false,
                    UseShellExecute = false,
                    RedirectStandardOutput = true
                },
                EnableRaisingEvents = true
            };

            process.OutputDataReceived += Process_OutputDataReceived; ;
            process.Start();
            process.BeginOutputReadLine();

        }

        private static int asd = 0;

        private static void Process_OutputDataReceived(object sender, DataReceivedEventArgs e)
        {
            asd++;
            Console.WriteLine(asd);
        }

    }
}
