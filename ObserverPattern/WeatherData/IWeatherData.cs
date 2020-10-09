using ObserverPattern.Displays;

namespace ObserverPattern.WeatherData
{
    public interface IWeatherData
    {
        void AddDisplay(IWeatherDataDisplay weatherDataDisplay);

        void RemoveDisplay(IWeatherDataDisplay weatherDataDisplay);

        void UpdateDisplays(WeatherDataEventArgs weatherDataEventArgs);
    }
}