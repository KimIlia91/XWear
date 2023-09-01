using ErrorOr;
using MapsterMapper;
using MediatR;
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
    protected IActionResult Problem(List<Error> errors)
    {
        if (errors.All(error => error.Type == ErrorType.Validation))
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

        HttpContext.Items[HttpContextItemKeys.Errors] = errors;
        var firstError = errors[0];
        var statusCode = firstError.Type switch
        {
            ErrorType.Conflict => StatusCodes.Status409Conflict,
            ErrorType.Validation => StatusCodes.Status400BadRequest,
            ErrorType.NotFound => StatusCodes.Status404NotFound,
            _ => StatusCodes.Status500InternalServerError,
        };

        return Problem(statusCode: statusCode, title: firstError.Description);
    }
}
