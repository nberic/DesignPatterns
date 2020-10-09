using ObserverPattern.Displays;
using ObserverPattern.WeatherData;

namespace ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // Subject
            var weatherData = new WeatherData.WeatherData();

            // Innitial Observers
            var greenConsoleWeatherDataDisplay = new GreenConsoleWeatherDataDisplay();
            var yellowConsoleWeatherDataDisplay = new YellowConsoleWeatherDataDisplay();
            greenConsoleWeatherDataDisplay.Subscribe(weatherData);
            yellowConsoleWeatherDataDisplay.Subscribe(weatherData);

            var currentWeatherData = new WeatherDataEventArgs()
            {
                Temperature = 15.0,
                BarometricPressure = 980,
                Humidity = 75
            };

            // Update
            weatherData.UpdateDisplays(currentWeatherData);

            // New Observer
            var redConsoleWeatherDataDisplay = new RedConsoleWeatherDataDisplay();
            redConsoleWeatherDataDisplay.Subscribe(weatherData);

            currentWeatherData = new WeatherDataEventArgs()
            {
                Temperature = 13.0,
                BarometricPressure = 900,
                Humidity = 65
            };

            // Update
            weatherData.UpdateDisplays(currentWeatherData);

            // Unsubscribe
            greenConsoleWeatherDataDisplay.Unsubscribe(weatherData);

            currentWeatherData = new WeatherDataEventArgs()
            {
                Temperature = 11.0,
                BarometricPressure = 880,
                Humidity = 60
            };

            // Uppdate
            weatherData.UpdateDisplays(currentWeatherData);


        }
    }
}
