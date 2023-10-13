using Microsoft.AspNetCore.Mvc;
using XWear.Contracts.Catalog.Responses;
using XWear.Application.Features.CatalogContext.Queries.GetLastUpdatedProductsByCategory;
using XWear.Application.Features.CatalogContext.Queries.GetCatalogsWithCategories;

namespace XWear.WebApi.Controllers;

/// <summary>
/// Контроллер для каталога
/// </summary>
public class CatalogController : ApiController
{
    /// <summary>
    /// Получить каталоги с последними добавленными продуктами
    /// </summary>
    /// <returns>Лист каталогов с последними добавленными продуктами</returns>
    [HttpGet("LastAddedProduct")]
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

    /// <summary>
    /// Получить каталоги с категориями
    /// </summary>
    /// <returns>Лист каталогов с категориями</returns>
    [HttpGet("Categories")]
    [ProducesResponseType(typeof(List<CatalogsWithCategoriesResponse>),
        StatusCodes.Status200OK)]
    public async Task<IActionResult> GetCatalogsWithCategoriesAsync()
    {
        var query = new GetCatalogsWithCategoriesQuery();
        var result = await Mediator.Send(query);
        return result.Match(
            result => Ok(Mapper.Map<List<CatalogsWithCategoriesResponse>>(result)),
            errors => Problem(errors));
    }
}
