using SmartBuildingConsoleApp.DigitalTwins;
using System;
using System.Threading.Tasks;
using System.IO;
using System.Collections.Generic;
using Azure;
using Azure.DigitalTwins.Core;


namespace SmartBuildingConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            DigitalTwinsManager dtHelper = new DigitalTwinsManager();

            // TODO
            string[] paths = new string[] {
                "Sensors/sensor.json"
            };

            foreach (var path in paths)
            {
                if (File.Exists(path))
                {
                    dtHelper.CreateModel(path);
                }
                else
                {
                    Console.WriteLine($"⚠️ File not found: {path}");
                }
            }



        }
    }
}