using ObserverPattern.WeatherData;

namespace ObserverPattern.Displays
{
    public interface IWeatherDataDisplay
    {
        void Update(object Sender, WeatherDataEventArgs weatherDataEventArgs);

        void Subscribe(IWeatherData weatherData);

        void Unsubscribe(IWeatherData weatherData);
    }
}