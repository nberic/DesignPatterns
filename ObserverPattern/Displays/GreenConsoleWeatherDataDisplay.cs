using System;
using ObserverPattern.WeatherData;

namespace ObserverPattern.Displays
{
    public class GreenConsoleWeatherDataDisplay : ConsoleWeatherDataDisplay
    {
        public override void Update(object Sender, WeatherDataEventArgs weatherDataEventArgs)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Console Weather Data");
            Console.ResetColor();
            
            Console.WriteLine(
                $"Current temperature: { weatherDataEventArgs.Temperature }");

            Console.WriteLine(
                $"Current pressure: { weatherDataEventArgs.BarometricPressure }");

            Console.WriteLine(
                $"Current humidity: { weatherDataEventArgs.Humidity }");
                
            Console.WriteLine("--------------------------------------");
        }
    }
}