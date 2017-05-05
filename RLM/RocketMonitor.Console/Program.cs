using System;

namespace RocketMonitor.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var rocketMonitor = new RocketMonitor();

            var filePath = Environment.GetEnvironmentVariable("USERPROFILE") + "\\Documents\\my games\\Rocket League\\TAGame\\Config\\TASystemSettings.ini";
            var newResolution = "3840";

            rocketMonitor.ChangeResolution(filePath, newResolution);
        }
    }
}