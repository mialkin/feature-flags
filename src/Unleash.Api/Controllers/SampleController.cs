using Microsoft.AspNetCore.Mvc;

namespace Unleash.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class SampleController : ControllerBase
{
    private readonly IUnleash _unleash;

    public SampleController(IUnleash unleash) => _unleash = unleash;

    [HttpGet("check-super-awesome-feature")]
    public IActionResult GetCurrentUtcDate()
    {
        return Ok(_unleash.IsEnabled(FeatureToggleNames.SuperAwesomeFeature) ? "enabled" : "disabled");
    }
}
