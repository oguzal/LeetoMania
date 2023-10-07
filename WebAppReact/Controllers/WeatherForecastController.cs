using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.InteropServices;

namespace WebAppReact.Controllers
{
//    [Authorize]
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILogger<WeatherForecastController> _logger;

        private readonly HttpClient _httpClient;
        private readonly string _apiKey;
        private readonly string _baseUrl;
        private readonly string _forecastExt;
        private readonly IConfiguration _configuration;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, IConfiguration _configuration)
        {
            _logger = logger;
            _httpClient = new HttpClient();
            _apiKey = _configuration.GetValue<string>("WeatherApi:ApiKey");
            _baseUrl = _configuration.GetValue<string>("WeatherApi:BaseUrl");
            _forecastExt = _configuration.GetValue<string>("WeatherApi:ForecastExtension");
        }

        //[HttpGet]
        //public IEnumerable<WeatherForecast> Get2()
        //{
        //    return Enumerable.Range(1, 5).Select(index => new WeatherForecast
        //    {
        //        Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
        //        TemperatureC = Random.Shared.Next(-20, 55),
        //        Summary = Summaries[Random.Shared.Next(Summaries.Length)]
        //    })
        //    .ToArray();
        //}

        [HttpGet]
        public async Task<dynamic> Get()
        {
            string input = "08807";
//        https://api.weatherapi.com/v1/forecast.json?q=08807&days=14&key=e34a69a06b1a4af796325047233009
            var resultRaw =await  _httpClient.GetAsync(_baseUrl + _forecastExt + "?q=" + input +"&days=14"+ "&key=" + _apiKey);
            var result=  resultRaw.Content.ReadFromJsonAsync<dynamic>();

            var file = new FileInfo("test.json");
            file.OpenRead();
            return result.Result;
        }
    }
}