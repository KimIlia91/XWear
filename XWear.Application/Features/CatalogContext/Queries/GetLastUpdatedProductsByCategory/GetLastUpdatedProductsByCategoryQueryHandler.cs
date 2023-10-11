using ErrorOr;
using MediatR;
using XWear.Contracts.Catalog.Responses;
using XWear.Application.Common.Interfaces.IRepositories;

namespace XWear.Application.Features.CatalogContext.Queries.GetLastUpdatedProductsByCategory;

public sealed class GetLastUpdatedProductsByCategoryQueryHandler
    : IRequestHandler<GetLastUpdatedProductsByCategoryQuery, ErrorOr<List<CatalogResponse>>>
{
    private readonly ICatalogRepository _catalogRepository;

    public GetLastUpdatedProductsByCategoryQueryHandler(
        ICatalogRepository catalogRepository)
    {
        _catalogRepository = catalogRepository;
    }

    public async Task<ErrorOr<List<CatalogResponse>>> Handle(
        GetLastUpdatedProductsByCategoryQuery query, 
        CancellationToken cancellationToken)
    {
        return await _catalogRepository
            .GetLastUpdatedProductsByCategoryAsync(cancellationToken);
    }
}