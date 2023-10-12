using ErrorOr;
using MediatR;
using XWear.Application.Common.Interfaces.IRepositories;
using XWear.Application.Features.CatalogContext.Common;

namespace XWear.Application.Features.CatalogContext.Queries.GetLastUpdatedProductsByCategory;

public sealed class GetLastUpdatedProductsByCategoryQueryHandler
    : IRequestHandler<GetLastUpdatedProductsByCategoryQuery, ErrorOr<List<CatalogResult>>>
{
    private readonly ICatalogRepository _catalogRepository;

    public GetLastUpdatedProductsByCategoryQueryHandler(
        ICatalogRepository catalogRepository)
    {
        _catalogRepository = catalogRepository;
    }

    public async Task<ErrorOr<List<CatalogResult>>> Handle(
        GetLastUpdatedProductsByCategoryQuery query, 
        CancellationToken cancellationToken)
    {
        return await _catalogRepository
            .GetLastUpdatedProductsByCategoryAsync(cancellationToken);
    }
}