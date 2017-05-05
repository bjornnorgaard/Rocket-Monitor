using System;
using System.IO;

namespace RLM
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = Environment.GetEnvironmentVariable("USERPROFILE") + "\\Documents\\my games\\Rocket League\\TAGame\\Config";
            var files = Directory.GetFiles(path);

            foreach (var file in files)
            {
                Console.WriteLine(file);
            }
        }
    }
}