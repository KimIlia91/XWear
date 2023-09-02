using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using XWear.Application.Common.Resources;

namespace XWear.WebApi.Controllers;

/// <summary>
/// Контроллер для проверки.
/// </summary>
[Route("api/isItWork")]
[Authorize]
public class TestController : ApiController
{
    /// <summary>
    /// Проверка.
    /// </summary>
    /// <returns>Строка, указывающая на успешную работу контроллера.</returns>
    [HttpGet]
    [AllowAnonymous]
    [ProducesResponseType(typeof(string), StatusCodes.Status200OK)]
    public IActionResult IsItWork()
    {
        return Ok(SuccessResources.TestLocalization);
    }

    /// <summary>
    /// Проверка авторизации
    /// </summary>
    /// <returns>Сообщение о том что авторизация работает</returns>
    [HttpGet("authorization")]
    [ProducesResponseType(typeof(string), StatusCodes.Status200OK)]
    public IActionResult AutheticationTest()
    {
        return Ok(SuccessResources.TestLocalization);
    }
}