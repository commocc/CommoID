using Commo.Id.WebHost.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace Commo.Id.WebHost.Controllers;

[ApiController]
[Route("[controller]")]
public class PersonalityController : ControllerBase
{
    private readonly ILogger<PersonalityController> _logger;

    public PersonalityController(ILogger<PersonalityController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public GetPersonalityResponse Get([FromQuery] GetPersonalityRequest request)
    {
        return new GetPersonalityResponse();
    }

    [HttpPut]
    public void Put([FromBody] PutPersonalityRequest request)
    {
    }
}
