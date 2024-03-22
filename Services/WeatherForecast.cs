namespace FHIR.Services
{
    public interface IWeatherForecastService
    {
        IEnumerable<WeatherForecast> GetWeatherForecasts();
    }

    public class WeatherForecastService : IWeatherForecastService
    {
        public IEnumerable<WeatherForecast> GetWeatherForecasts()
        {
            var rng = new Random();
            var forecasts = new List<WeatherForecast>();

            for (int i = 0; i < 5; i++)
            {
                var forecast = new WeatherForecast
                {
                    Date = DateTime.Now.AddDays(i),
                    TemperatureC = rng.Next(-20, 55),
                    Summary = "Sample Summary"
                };

                forecasts.Add(forecast);
            }

            return forecasts;
        }
    }

    public class WeatherForecast
    {
        public DateTime Date { get; set; }
        public int TemperatureC { get; set; }
        public string? Summary { get; set; }
        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
    }
}