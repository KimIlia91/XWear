using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using XWear.Contracts.Product.Requests;
using XWear.Contracts.Product.Responses;
using XWear.Contracts.FavoritProduct.Requests;
using XWear.Contracts.FavoritProduct.Responses;
using XWear.Application.Features.FavoritProductContext.Commands.AddFavoritProduct;
using XWear.Application.Features.FavoritProductContext.Commands.DeleteFavoritProduct;

namespace XWear.WebApi.Controllers
{
    /// <summary>
    /// Контроллер для избранных продуктов пользователя
    /// </summary>
    [Authorize]
    public class FavoritProductController : ApiController
    {
        /// <summary>
        /// Добавить продукт в избранное пользователя
        /// </summary>
        /// <returns> </returns>
        [HttpPost]
        [ProducesResponseType(typeof(AddFavoritProductResponse), StatusCodes.Status200OK)]
        public async Task<IActionResult> AddProductToFavoritsAsync(AddFavoritProductRequest request)
        {
            var command = new AddFavoritPoductCommand(request.ProductId);
            var result = await Mediator.Send(command);
            return result.Match(
                result => Ok(Mapper.Map<AddFavoritProductResponse>(result)),
                errors => Problem(errors));
        }

        /// <summary>
        /// Удалить продукт из избранного пользователя
        /// </summary>
        /// <returns> </returns>
        [HttpDelete]
        [ProducesResponseType(typeof(DeleteFavoritProductResponse), StatusCodes.Status200OK)]
        public async Task<IActionResult> RemoveProductFromFavoritsAsync(DeleteFavoritProductRequest request)
        {
            var command = new DeleteFavoritProductCommand(request.ProductId);
            var result = await Mediator.Send(command);
            return result.Match(
                result => Ok(Mapper.Map<DeleteFavoritProductResponse>(result)),
                errors => Problem(errors));
        }
    }
}
