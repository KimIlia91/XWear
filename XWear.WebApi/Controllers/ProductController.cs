using Microsoft.AspNetCore.Mvc;
using XWear.Application.Features.CatalogContext.Queries.GetLastUpdatedProductsByCategory;
using XWear.Application.Features.ProductContext.Commands.AddPoductToFavorits;
using XWear.Application.Features.ProductContext.Queries.GetProductPage;
using XWear.Contracts.Catalog.Responses;
using XWear.Contracts.Product.Requests;
using XWear.Contracts.Product.Responses;

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

    /// <summary>
    /// 
    /// </summary>
    /// <returns> </returns>
    [HttpPost("AddProductToFavorits")]
    [ProducesResponseType(typeof(AddProductToFavoritsResponse), StatusCodes.Status200OK)]
    public async Task<IActionResult> AddProductToFavoritsAsync(AddProductToFavoritsRequest request)
    {
        var command = new AddPoductToFavoritsCommand(request.ProductId);
        var result = await Mediator.Send(command);
        return result.Match(
            result => Ok(Mapper.Map<AddProductToFavoritsResponse>(result)),
            errors => Problem(errors));
    }
}
