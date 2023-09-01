using Microsoft.AspNetCore.Mvc;
using XWear.Contracts.Authetication;
using XWear.Application.Authentication.Queries.Login;
using XWear.Application.Authentication.Commands.Register;
using XWear.Application.Authentication.Common;

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
        var command = new RegisterCommand(
            request.FirstName,
            request.LastName,
            request.Email,
            request.Phone,
            request.Password,
            request.ConfirmPassword);

        var authResult = await Mediator.Send(command);
        return authResult.Match(
            authResult => Ok(MapAuthResult(authResult)),
            errors => Problem(errors));
    }

    private AuthenticationResponse? MapAuthResult(AuthenticationResult authResult)
    {
        return new AuthenticationResponse(
           authResult.Email,
           authResult.AccessToken,
           authResult.RefreshToken);
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
        var query = new LoginQuery(request.Email, request.Password);
        var authResult = await Mediator.Send(query);
        return authResult.Match(
         authResult => Ok(MapAuthResult(authResult)),
         errors => Problem(errors));
    }
}
