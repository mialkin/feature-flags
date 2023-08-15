using Microsoft.AspNetCore.Mvc;

namespace Unleash.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    [HttpGet("GetWeatherForecast")]
    public IActionResult Get()
    {
        return Ok();
    }
}
