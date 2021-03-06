﻿using System;

namespace RocketMonitor.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var rocketMonitor = new RocketMonitor();

            var filePath = Environment.GetEnvironmentVariable("USERPROFILE") + "\\Documents\\my games\\Rocket League\\TAGame\\Config\\TASystemSettings.ini";
            const int baseXresolution = 1920;
            int numberOfPlayers;

            System.Console.Write("Number of players: ");

            try
            {
                numberOfPlayers = int.Parse(System.Console.ReadLine());
            }
            catch (Exception)
            {
                System.Console.WriteLine("... NUMBER of players. Not letter of player, dumb user.");
                System.Threading.Thread.Sleep(2000);
                return;
            }

            var newResolution = numberOfPlayers * baseXresolution;

            if (0 < numberOfPlayers && numberOfPlayers < 5)
            {
                System.Console.WriteLine("Setting new game resolution...");
                rocketMonitor.ChangeHorizontalResolution(filePath, newResolution.ToString());
                System.Console.WriteLine("Now you can launch the game.");
                System.Threading.Thread.Sleep(2000);
                return;
            }

            System.Console.WriteLine("Oops. Something didn't work.");
            System.Threading.Thread.Sleep(2000);
        }
    }
}