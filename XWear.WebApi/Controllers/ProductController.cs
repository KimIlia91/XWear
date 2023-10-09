using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using XWear.Contracts.Product.Responses;
using XWear.Application.Features.ProductContext.Queries.GetProducts;
using XWear.Application.Features.ProductContext.Queries.GetProductsByCategoryId;
using XWear.Application.Features.ProductContext.Commands;
using XWear.Application.Features.ProductContext.Commands.AddFavoritProductCommand;
using XWear.Contracts.Product.Request;

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
        [ProducesResponseType(typeof(IEnumerable<CatalogResponse>), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetProductsAsync()
        {
            var query = new GetProductsByCategoryQuery();
            var productResults = await Mediator.Send(query);
            return productResults.Match(
                productResults => Ok(Mapper.Map<List<CatalogResponse>>(productResults)),
                errors => Problem(errors));
        }

        /// <summary>
        /// Получения списка товаров по Id каталога.
        /// </summary>
        /// <returns>Список товаров по Id каталога.</returns>
        [HttpGet("{catalogId}")]
        [ProducesResponseType(typeof(IEnumerable<ProductResponse>), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetProductsByCatalogIdAsync(Guid catalogId)
        {
            var query = new GetProductsByCatalogIdQuery(catalogId);
            var productResults = await Mediator.Send(query);
            return productResults.Match(
                productResults => Ok(Mapper.Map<List<ProductResponse>>(productResults)),
                errors => Problem(errors));
        }

        /// <summary>
        /// Получения списка товаров по Id каталога.
        /// </summary>
        /// <returns>Список товаров по Id каталога.</returns>
        [HttpPost]
        [ProducesResponseType(typeof(IEnumerable<ProductResponse>), StatusCodes.Status200OK)]
        public async Task<IActionResult> AddFavoritProductAsync(AddProductToFavoriteRequest request)
        {
            var command = new AddProductToFavoriteCommand(request.ProductId);
            var productResults = await Mediator.Send(command);
            return productResults.Match(
                productResults => Ok(Mapper.Map<AddedFavoritProductReponse>(productResults)),
                errors => Problem(errors));
        }
    }
}
