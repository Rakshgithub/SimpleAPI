using Microsoft.AspNetCore.Mvc;

namespace SimpleAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    [HttpGet("{id}")]
public ActionResult<string> Get(int id)
    {
        return "Les Jackson";
    }
}
