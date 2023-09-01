using Microsoft.AspNetCore.Mvc;

namespace XWear.WebApi.Controllers;

[Route("api/isItWork")]
public class TestController : ApiController
{
    [HttpGet]
    [ProducesResponseType(typeof(string), StatusCodes.Status200OK)]
    public IActionResult IsItWork()
    {
        return Ok("It's work!");
    }
}