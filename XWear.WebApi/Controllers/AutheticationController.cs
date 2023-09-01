using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;

namespace XWear.WebApi.Controllers
{
    [Route("Auth")]
    public class AutheticationController : ApiController
    {
        private readonly IAuthenticationService _authenticationService;

        public AutheticationController(IAuthenticationService authenticationService)
        {
            _authenticationService = authenticationService;
        }

        [HttpPost("register")]
        public IActionResult Register()
        {
            return Ok("In developing");
        }

        [HttpPost("login")]
        public IActionResult Login()
        {
            return Ok("In developing");
        }
    }
}
