using System;
using Microsoft.AspNetCore.Mvc;

namespace Unleash.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class SampleController : ControllerBase
{
    [HttpGet("get-current-utc-date")]
    public IActionResult GetCurrentUtcDate()
    {
        var utc = DateTime.UtcNow;

        return Ok(utc);
    }
}
