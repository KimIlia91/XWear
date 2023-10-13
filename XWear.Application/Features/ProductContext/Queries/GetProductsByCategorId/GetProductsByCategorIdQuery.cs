using ErrorOr;
using MediatR;
using XWear.Application.Features.ProductContext.Common;

namespace XWear.Application.Features.ProductContext.Queries.GetProductsByCategorId;

public sealed record GetProductsByCategorIdQuery(
    Guid CategoryId) : IRequest<ErrorOr<List<ProductResult>>>;
