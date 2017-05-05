using System;
using System.IO;

namespace RLM
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = Environment.GetEnvironmentVariable("USERPROFILE") + "\\Documents\\my games\\Rocket League\\TAGame\\Config\\TASystemSettings.ini";
            var lines = File.ReadAllLines(path);

            for (var index = 0; index < lines.Length; index++)
            {
                var line = lines[index];
                if (line.Contains("ResX=1920"))
                {
                    lines[index] = "ResX=3840";
                }
            }

            File.WriteAllLines(path, lines);
        }
    }
}