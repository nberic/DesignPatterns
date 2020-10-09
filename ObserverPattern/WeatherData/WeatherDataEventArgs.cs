using System;

namespace ObserverPattern.WeatherData
{
    public class WeatherDataEventArgs : EventArgs
    {
        public double Temperature { get; set; }
        
        public double BarometricPressure { get; set; }

        public double Humidity { get; set; }
    }
}