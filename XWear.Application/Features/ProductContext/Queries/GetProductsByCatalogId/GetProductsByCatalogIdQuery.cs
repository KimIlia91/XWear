using ErrorOr;
using MediatR;
using XWear.Application.Features.ProductContext.Common;

namespace XWear.Application.Features.ProductContext.Queries.GetProductsByCatalogId;

public record GetProductsByCatalogIdQuery(
    Guid CatalogId) : IRequest<ErrorOr<IEnumerable<ProductResult>>>;
