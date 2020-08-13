using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace OdataWebApi.Controllers
{

    //https://devblogs.microsoft.com/odata/experimenting-with-odata-in-asp-net-core-3-1/

    //https://devblogs.microsoft.com/odata/supercharging-asp-net-core-api-with-odata/

    //https://www.odata.org/getting-started/understand-odata-in-6-steps/
    //Create login using normal post json request

    //https://dotnetthoughts.net/perform-crud-operations-using-odata-in-aspnet-core/


    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ODataController
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        [EnableQuery]
        [Route("Get")]
        public IEnumerable<WeatherForecast> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Id = Summaries[index],
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }

        [HttpPost]
        [EnableQuery]
        [Route("Post")]
        //POST : /api/Account/Login
        public IActionResult Post(LoginDto model)
        {
            return Ok(model);
        }
    }
}
