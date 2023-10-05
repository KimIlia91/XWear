using ErrorOr;
using MediatR;
using XWear.Application.Features.ProductContext.Common;

namespace XWear.Application.Features.ProductContext.Queries.GetProducts;

public record GetProductsByCategoryQuery : IRequest<ErrorOr<IEnumerable<ProductResult>>>;
