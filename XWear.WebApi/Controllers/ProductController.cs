using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using XWear.Application.Features.ProductContext.Queries.GetByProductSizeId;
using XWear.Application.Features.ProductContext.Queries.GetProductPage;
using XWear.Application.Features.ProductContext.Queries.GetProductsByCategorId;
using XWear.Contracts.Catalog.Responses;
using XWear.Contracts.Product.Responses;

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
    [ProducesResponseType(typeof(List<LastUpdatedProductsByCategoryResponse>), 
        StatusCodes.Status200OK)]
    public async Task<IActionResult> GetProductsPageAsync(
        [FromQuery] GetProductPageQuery query)
    {
        //var query = new GetLastUpdatedProductsByCategoryQuery();
        var result = await Mediator.Send(query);
        return result.Match(
            result => Ok(result),
            errors => Problem(errors));
    }

    /// <summary>
    /// Получить продукт по ID размера продукта
    /// </summary>
    /// <returns>Продукт по указанным ID</returns>
    [HttpGet("productSize/{productSizeId}")]
    [AllowAnonymous]
    [ProducesResponseType(typeof(ProductByProductSizeIdResponse), 
        StatusCodes.Status200OK)]
    public async Task<IActionResult> GetByProductSizeIdAsync(
        Guid productSizeId)
    {
        var query = new GetByProductSizeIdQuery(productSizeId);
        var result = await Mediator.Send(query);
        return result.Match(
            result => Ok(Mapper.Map<ProductByProductSizeIdResponse>(result)),
            errors => Problem(errors));
    }

    /// <summary>
    /// Получить продукты по ID категории
    /// </summary>
    /// <returns>Продукт по указанным ID</returns>
    [HttpGet("category/{categoryId}")]
    [AllowAnonymous]
    [ProducesResponseType(typeof(ProductByProductSizeIdResponse),
        StatusCodes.Status200OK)]
    public async Task<IActionResult> GetProductsByCategorIdAsync(
        Guid categoryId)
    {
        var query = new GetProductsByCategorIdQuery(categoryId);
        var result = await Mediator.Send(query);
        return result.Match(
            result => Ok(Mapper.Map<List<ProductResponse>>(result)),
            errors => Problem(errors));
    }
}
