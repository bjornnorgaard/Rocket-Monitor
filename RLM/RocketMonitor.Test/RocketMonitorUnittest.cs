using System;
using Xunit;

namespace RocketMonitor.Test
{
    public class RocketMonitorUnittest
    {
        private readonly RocketMonitor _rocketMonitor;
        string _filePath = Environment.GetEnvironmentVariable("USERPROFILE") + "\\Documents\\my games\\Rocket League\\TAGame\\Config\\TASystemSettings.ini";


        public RocketMonitorUnittest()
        {
            _rocketMonitor = new RocketMonitor();
        }

        [Fact]
        public void ChangeResolution_NullPath_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => _rocketMonitor.ChangeResolution(null, "3840"));
        }

        [Fact]
        public void ChangeResolution_NullResolution_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => _rocketMonitor.ChangeResolution(_filePath, null));
        }

        [Fact]
        public void ChangeResolution_BothArgumentNull_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => _rocketMonitor.ChangeResolution(null, null));
        }
    }
}
