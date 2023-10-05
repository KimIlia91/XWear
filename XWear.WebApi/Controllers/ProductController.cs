using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using XWear.Application.Features.ProductContext.Queries.GetProducts;
using XWear.Contracts.Product.Responses;

namespace XWear.WebApi.Controllers
{
    /// <summary>
    /// Контроллер для работы с товарами
    /// </summary>
    [AllowAnonymous]
    public class ProductController : ApiController
    {
        /// <summary>
        /// Получения списка последних добавленых товаров по категориям.
        /// </summary>
        /// <returns>Список последних добавленых товаров по категориям.</returns>
        [HttpGet("byCategory")]
        [ProducesResponseType(typeof(IEnumerable<ProductResponse>), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetProductsAsync()
        {
            var query = new GetProductsByCategoryQuery();
            var productResults = await Mediator.Send(query);
            return productResults.Match(
                productResults => Ok(Mapper.Map<List<ProductResponse>>(productResults)),
                errors => Problem(errors));
        }
    }
}
