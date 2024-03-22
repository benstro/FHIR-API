using System.Text.Json;
using FHIR.Services;
using Microsoft.AspNetCore.Mvc;

namespace FHIR.Controllers
{
    [Route("api/weatherforecast")]
    [ApiController]
    public class WeatherForecastController(IWeatherForecastService weatherForecastService) : ControllerBase
    {
        private readonly IWeatherForecastService _weatherForecastService = weatherForecastService;

        [HttpGet]
        public string Get()
        {
            var weatherforecast = _weatherForecastService.GetWeatherForecasts();

            var json = JsonSerializer.Serialize(weatherforecast);
            return json;
        }
    }
}
