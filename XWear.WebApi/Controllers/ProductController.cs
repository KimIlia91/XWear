using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using XWear.Application.Features.ProductContext.Queries.GetProductPage;
using XWear.Contracts.Catalog.Responses;

namespace XWear.WebApi.Controllers;

/// <summary>
/// Контроллер для работы с продуктами
/// </summary>
[Authorize]
public class ProductController : ApiController
{
    /// <summary>
    /// В разработке
    /// </summary>
    /// <returns> </returns>
    [HttpGet]
    [AllowAnonymous]
    [ProducesResponseType(typeof(List<LastUpdatedProductsByCategoryResponse>), StatusCodes.Status200OK)]
    public async Task<IActionResult> GetProductsPageAsync([FromQuery] GetProductPageQuery query)
    {
        //var query = new GetLastUpdatedProductsByCategoryQuery();
        var result = await Mediator.Send(query);
        return result.Match(
            result => Ok(result),
            errors => Problem(errors));
    }
}
