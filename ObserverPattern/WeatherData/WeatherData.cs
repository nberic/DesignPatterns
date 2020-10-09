using System;
using ObserverPattern.Displays;

namespace ObserverPattern.WeatherData
{
    public class WeatherData : IWeatherData
    {
        public event EventHandler<WeatherDataEventArgs> OnWeatherDataChanged;

        public WeatherData()
        {

        }

        public void AddDisplay(IWeatherDataDisplay weatherDataDisplay)
        {
            OnWeatherDataChanged += weatherDataDisplay.Update;
        }

        public void RemoveDisplay(IWeatherDataDisplay weatherDataDisplay)
        {
            OnWeatherDataChanged -= weatherDataDisplay.Update;
        }

        public void UpdateDisplays(WeatherDataEventArgs weatherDataEventArgs)
        {
            Console.WriteLine("");
            OnWeatherDataChanged?.Invoke(this, weatherDataEventArgs);
        }
    }
}