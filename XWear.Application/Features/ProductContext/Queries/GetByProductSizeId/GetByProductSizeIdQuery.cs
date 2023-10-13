using ErrorOr;
using MediatR;
using XWear.Application.Features.ProductContext.Common;

namespace XWear.Application.Features.ProductContext.Queries.GetByProductSizeId;

public sealed record GetByProductSizeIdQuery(
    Guid ProductSizeId) : IRequest<ErrorOr<ProductByIdResult>>;