using Microsoft.AspNetCore.Mvc;
using XWear.Contracts.Authetication;
using XWear.Application.Features.Authentication.Common;
using XWear.Application.Features.Authentication.Queries.Login;
using XWear.Application.Features.Authentication.Commands.Register;

namespace XWear.WebApi.Controllers;

/// <summary>
/// Контроллер для аутентификации и авторизации.
/// </summary>
[Route("api/auth")]
public class AutheticationController : ApiController
{
    /// <summary>
    /// Регистрация нового пользователя.
    /// </summary>
    /// <param name="request">Запрос на регистрацию пользователя.</param>
    /// <returns>Результат аутентификации.</returns>
    [HttpPost("register")]
    [ProducesResponseType(typeof(AuthenticationResult), StatusCodes.Status200OK)]
    public async Task<IActionResult> Register(RegisterRequest request)
    {
        var command = Mapper.Map<RegisterCommand>(request);
        var authResult = await Mediator.Send(command);
        return authResult.Match(
            authResult => Ok(Mapper.Map<AuthenticationResponse>(authResult)),
            errors => Problem(errors));
    }

    /// <summary>
    /// Вход пользователя в систему.
    /// </summary>
    /// <param name="request">Запрос на вход в систему.</param>
    /// <returns>Результат аутентификации.</returns>
    [HttpPost("login")]
    [ProducesResponseType(typeof(AuthenticationResult), StatusCodes.Status200OK)]
    public async Task<IActionResult> Login(LoginRequest request)
    {
        var query = Mapper.Map<LoginQuery>(request);
        var authResult = await Mediator.Send(query);
        return authResult.Match(
         authResult => Ok(Mapper.Map<AuthenticationResponse>(authResult)),
         errors => Problem(errors));
    }
}
