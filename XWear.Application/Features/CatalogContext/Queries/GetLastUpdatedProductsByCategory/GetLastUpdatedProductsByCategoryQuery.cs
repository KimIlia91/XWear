using ErrorOr;
using MediatR;
using XWear.Application.Features.CatalogContext.Common;

namespace XWear.Application.Features.CatalogContext.Queries.GetLastUpdatedProductsByCategory;

public sealed record GetLastUpdatedProductsByCategoryQuery : IRequest<ErrorOr<List<CatalogResult>>>;
