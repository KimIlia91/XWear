using ErrorOr;
using MapsterMapper;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using XWear.WebApi.Common.Http;

namespace XWear.WebApi.Controllers;

/// <summary>
/// Базовый контроллер
/// </summary>
[ApiController]
[Route("api/[controller]")]
public class ApiController : ControllerBase
{
    private ISender _mediator;
    private IMapper _mapper;

    /// <summary>
    /// Mediator
    /// </summary>
    protected ISender Mediator => _mediator ??= HttpContext.RequestServices.GetService<ISender>()!;

    /// <summary>
    /// Mapper
    /// </summary>
    protected IMapper Mapper => _mapper ??= HttpContext.RequestServices.GetService<IMapper>()!;

    /// <summary>
    /// Метод для обработки исключений
    /// </summary>
    /// <param name="errors"></param>
    /// <returns></returns>
    [Route("/error")]
    protected IActionResult Problem(List<Error> errors)
    {
        if (errors.Count is 0) return Problem();

        if (errors.All(error => error.Type == ErrorType.Validation))
            return ValidationProblem(errors);

        HttpContext.Items[HttpContextItemKeys.Errors] = errors;
        return Problem(errors[0]);
    }

    private IActionResult Problem(Error error)
    {
        var statusCode = error.Type switch
        {
            ErrorType.Conflict => StatusCodes.Status409Conflict,
            ErrorType.Validation => StatusCodes.Status400BadRequest,
            ErrorType.NotFound => StatusCodes.Status404NotFound,
            _ => StatusCodes.Status500InternalServerError,
        };

        return Problem(statusCode: statusCode, title: error.Description);
    }

    private IActionResult ValidationProblem(List<Error> errors)
    {
        var modelStateDictionary = new ModelStateDictionary();

        foreach (var error in errors)
        {
            modelStateDictionary.AddModelError(
                error.Code,
                error.Description);
        }

        return ValidationProblem(modelStateDictionary);
    }
}
