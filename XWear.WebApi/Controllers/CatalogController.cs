using Microsoft.AspNetCore.Mvc;
using XWear.Application.Features.CatalogContext.Commands.CreateCatalog;
using XWear.Application.Features.ProductContext.Queries.GetProducts;
using XWear.Contracts.Catalog.Requests;
using XWear.Contracts.Product.Responses;

namespace XWear.WebApi.Controllers
{
    public class CatalogController : ApiController
    {
        [HttpGet("byCategory")]
        [ProducesResponseType(typeof(IEnumerable<CatalogResponse>), StatusCodes.Status200OK)]
        public async Task<IActionResult> CreateCatalogAsync(CreateCatalogRequest request)
        {
            var command = Mapper.Map<CreateCatalogCommand>(request);
            var catalogResult = await Mediator.Send(command);
            return catalogResult.Match(
                productResults => Ok(Mapper.Map<List<CatalogResponse>>(productResults)),
                errors => Problem(errors));
        }
    }
}
