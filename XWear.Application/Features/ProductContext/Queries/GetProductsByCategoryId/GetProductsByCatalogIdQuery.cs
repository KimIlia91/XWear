using ErrorOr;
using MediatR;
using XWear.Application.Features.ProductContext.Common;

namespace XWear.Application.Features.ProductContext.Queries.GetProductsByCategoryId;

public record GetProductsByCatalogIdQuery(
    Guid CategoryId) : IRequest<ErrorOr<IEnumerable<ProductResult>>>;
