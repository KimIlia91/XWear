using Microsoft.AspNetCore.Mvc;
using XWear.Application.Common.Resources;

namespace XWear.WebApi.Controllers;

/// <summary>
/// Контроллер для проверки.
/// </summary>
[Route("api/isItWork")]
public class TestController : ApiController
{
    /// <summary>
    /// Проверка.
    /// </summary>
    /// <returns>Строка, указывающая на успешную работу контроллера.</returns>
    [HttpGet]
    [ProducesResponseType(typeof(string), StatusCodes.Status200OK)]
    public IActionResult IsItWork()
    {
        return Ok(SuccessResources.TestLocalization);
    }
}