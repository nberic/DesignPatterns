using System;
using ObserverPattern.WeatherData;

namespace ObserverPattern.Displays
{
    public class YellowConsoleWeatherDataDisplay : ConsoleWeatherDataDisplay
    {
        public override void Update(object Sender, WeatherDataEventArgs weatherDataEventArgs)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
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