using Microsoft.AspNetCore.Mvc;

namespace lab42.Controllers;

[ApiController]
[Route("/")]
public class WeatherForecastController : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        return Assembly.GetEntryAssembly().GetCustomAttribute<AssemblyInformationalVersionAttribute>().InformationalVersion;
    }
}
