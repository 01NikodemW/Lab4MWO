using System.Reflection;
using Microsoft.AspNetCore.Mvc;

namespace lab42.Controllers;

[ApiController]
[Route("/")]
public class WeatherForecastController : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        return Ok(Assembly.GetEntryAssembly().GetCustomAttribute<AssemblyInformationalVersionAttribute>().InformationalVersion);
    }
}
