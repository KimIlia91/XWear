using Microsoft.AspNetCore.Mvc;

namespace XWear.WebApi.Controllers
{
    public class TestController : ApiController
    {
        [HttpGet]
        [ProducesResponseType(typeof(string), StatusCodes.Status200OK)]
        public IActionResult Test()
        {
            return Ok("It's work!");
        }
    }
}