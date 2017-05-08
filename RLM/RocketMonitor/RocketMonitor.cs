﻿using System;
using System.IO;

namespace RocketMonitor
{
    public class RocketMonitor
    {
        public void ChangeResolution(string filePath, string newResolution)
        {
            if (filePath == null || newResolution == null)
            {
                throw new ArgumentException($"{nameof(ChangeResolution)} failed when given " +
                                            $"{nameof(filePath)}: {filePath} and " +
                                            $"{nameof(newResolution)}: {newResolution}.");
            }

            var lines = File.ReadAllLines(filePath);

            for (var index = 0; index < lines.Length; index++)
            {
                var line = lines[index];
                for (int i = 1; i < 5; i++)
                {
                    if (line.Contains($"ResX={1920*i}"))
                    {
                        lines[index] = "ResX=" + newResolution;
                    }
                }
            }

            File.WriteAllLines(filePath, lines);
        }
    }
}
