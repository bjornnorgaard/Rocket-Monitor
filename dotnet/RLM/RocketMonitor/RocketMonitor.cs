using System;
using System.IO;

namespace RocketMonitor
{
    public class RocketMonitor
    {
        public void ChangeHorizontalResolution(string filePath, string newResolution)
        {
            if (filePath == null || newResolution == null)
            {
                throw new NullReferenceException($"{nameof(ChangeHorizontalResolution)} failed when given " +
                                                 $"{nameof(filePath)}: {filePath} and " +
                                                 $"{nameof(newResolution)}: {newResolution}.");
            }
            
            var lines = File.ReadAllLines(filePath);

            for (var index = 0; index < lines.Length; index++)
            {
                var line = lines[index];

                if (line.Contains($"ResX=1920") || line.Contains("ResX=3840"))
                {
                    lines[index] = "ResX=" + newResolution;
                }
            }

            File.WriteAllLines(filePath, lines);
        }
    }
}
