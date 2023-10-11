using Microsoft.AspNetCore.Mvc;
using XWear.Application.Features.CatalogContext.Queries.GetLastUpdatedProductsByCategory;
using XWear.Application.Features.ProductContext.Queries.GetProductPage;
using XWear.Contracts.Catalog.Responses;

namespace XWear.WebApi.Controllers;

public class ProductController : ApiController
{
    /// <summary>
    /// 
    /// </summary>
    /// <returns> </returns>
    [HttpGet]
    [ProducesResponseType(typeof(List<CatalogResponse>), StatusCodes.Status200OK)]
    public async Task<IActionResult> GetProductsPageAsync([FromQuery] GetProductPageQuery query)
    {
        //var query = new GetLastUpdatedProductsByCategoryQuery();
        var result = await Mediator.Send(query);
        return result.Match(
            result => Ok(result),
            errors => Problem(errors));
    }
}
