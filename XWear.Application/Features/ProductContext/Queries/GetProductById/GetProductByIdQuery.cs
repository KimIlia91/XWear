using ErrorOr;
using MediatR;
using XWear.Application.Features.ProductContext.Common;

namespace XWear.Application.Features.ProductContext.Queries.GetProductById;

public sealed record GetProductByIdQuery(
    Guid Id,
    Guid ProductSizeId) : IRequest<ErrorOr<ProductByIdResult>>;