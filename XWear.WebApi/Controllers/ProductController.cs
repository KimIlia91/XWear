using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using XWear.Application.Features.ProductContext.Queries.GetProducts;
using XWear.Contracts.Product.Responses;

namespace XWear.WebApi.Controllers
{
    [AllowAnonymous]
    public class ProductController : ApiController
    {
        /// <summary>
        /// Получения списка товаров.
        /// </summary>
        /// <returns>Список товаров.</returns>
        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<ProductResponse>), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetProductsAsync()
        {
            var query = new GetProductsQuery();
            var productResults = await Mediator.Send(query);
            return productResults.Match(
                productResults => Ok(Mapper.Map<List<ProductResponse>>(productResults)),
                errors => Problem(errors));
        }
    }
}
