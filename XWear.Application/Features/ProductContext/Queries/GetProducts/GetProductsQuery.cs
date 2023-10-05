using ErrorOr;
using MediatR;
using XWear.Application.Features.ProductContext.Common;

namespace XWear.Application.Features.ProductContext.Queries.GetProducts;

public record GetProductsQuery : IRequest<ErrorOr<IEnumerable<ProductResult>>>;
