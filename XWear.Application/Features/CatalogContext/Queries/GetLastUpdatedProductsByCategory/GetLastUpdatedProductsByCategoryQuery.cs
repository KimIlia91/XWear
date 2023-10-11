using ErrorOr;
using MediatR;
using XWear.Contracts.Catalog.Responses;

namespace XWear.Application.Features.CatalogContext.Queries.GetLastUpdatedProductsByCategory;

public sealed record GetLastUpdatedProductsByCategoryQuery : IRequest<ErrorOr<List<CatalogResponse>>>;
