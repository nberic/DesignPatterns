using System;
using ObserverPattern.WeatherData;

namespace ObserverPattern.Displays
{
    public abstract class ConsoleWeatherDataDisplay : IWeatherDataDisplay
    {
        public virtual void Update(object Sender, WeatherDataEventArgs weatherDataEventArgs)
        {

            Console.WriteLine(
                $"Current temperature: { weatherDataEventArgs.Temperature }");

            Console.WriteLine(
                $"Current pressure: { weatherDataEventArgs.BarometricPressure }");

            Console.WriteLine(
                $"Current humidity: { weatherDataEventArgs.Humidity }");
        }

        public void Subscribe(IWeatherData weatherData)
        {
            weatherData.AddDisplay(this);
        }

        public void Unsubscribe(IWeatherData weatherData)
        {
            weatherData.RemoveDisplay(this);
        }
    }
}