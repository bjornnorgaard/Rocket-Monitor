using System.IO;

namespace RocketMonitor
{
    public class RocketMonitor
    {
        public void ChangeResolution(string filePath, string newResolution)
        {
            var path = filePath;
            var lines = File.ReadAllLines(path);

            for (var index = 0; index < lines.Length; index++)
            {
                var line = lines[index];
                if (line.Contains("ResX=1920"))
                {
                    lines[index] = "ResX=" + newResolution;
                }
            }

            File.WriteAllLines(path, lines);
        }
    }
}
