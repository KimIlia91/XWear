using Microsoft.AspNetCore.Mvc;
using XWear.Contracts.Catalog.Responses;
using XWear.Application.Features.CatalogContext.Queries.GetLastUpdatedProductsByCategory;

namespace XWear.WebApi.Controllers;

/// <summary>
/// Контроллер для каталога
/// </summary>
public class CatalogController : ApiController
{
    /// <summary>
    /// 
    /// </summary>
    /// <returns> </returns>
    [HttpGet]
    [ProducesResponseType(typeof(List<LastUpdatedProductsByCategoryResponse>), 
        StatusCodes.Status200OK)]
    public async Task<IActionResult> GetLastUpdatedProductsByCategoryAsync()
    {
        var query = new GetLastUpdatedProductsByCategoryQuery();
        var result = await Mediator.Send(query);
        return result.Match(
            result => Ok(Mapper.Map<List<LastUpdatedProductsByCategoryResponse>>(result)),
            errors => Problem(errors));
    }
}
