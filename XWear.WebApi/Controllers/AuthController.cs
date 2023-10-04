using Microsoft.AspNetCore.Mvc;
using XWear.Contracts.Authetication;
using XWear.Application.Features.Authentication.Queries.Login;
using XWear.Application.Features.Authentication.Commands.Register;
using Microsoft.AspNetCore.Authorization;

namespace XWear.WebApi.Controllers;

/// <summary>
/// Контроллер для аутентификации и авторизации.
/// </summary>
[Route("api/auth")]
[AllowAnonymous]
public class AuthController : ApiController
{
    /// <summary>
    /// Регистрация нового пользователя.
    /// </summary>
    /// <param name="request">Запрос на регистрацию пользователя.</param>
    /// <returns>Результат аутентификации.</returns>
    [HttpPost("register")]
    [ProducesResponseType(typeof(AuthResponse), StatusCodes.Status200OK)]
    public async Task<IActionResult> Register(RegisterRequest request)
    {
        var command = Mapper.Map<RegisterCommand>(request);
        var authResult = await Mediator.Send(command);
        return authResult.Match(
            authResult => Ok(Mapper.Map<AuthResponse>(authResult)),
            errors => Problem(errors));
    }

    /// <summary>
    /// Вход пользователя в систему.
    /// </summary>
    /// <param name="request">Запрос на вход в систему.</param>
    /// <returns>Результат аутентификации.</returns>
    [HttpPost("login")]
    [ProducesResponseType(typeof(AuthResponse), StatusCodes.Status200OK)]
    public async Task<IActionResult> Login(LoginRequest request)
    {
        var query = Mapper.Map<LoginQuery>(request);
        var authResult = await Mediator.Send(query);
        return authResult.Match(
         authResult => Ok(Mapper.Map<AuthResponse>(authResult)),
         errors => Problem(errors));
    }
}
