using ErrorOr;
using MediatR;
using XWear.Application.Common.Interfaces.IRepositories;
using XWear.Application.Features.CatalogContext.Common;

namespace XWear.Application.Features.CatalogContext.Queries.GetCatalogsWithCategories;

internal sealed class GetCatalogsWithCategoriesQueryHandler
    : IRequestHandler<GetCatalogsWithCategoriesQuery, ErrorOr<IEnumerable<CatalogWithCategoriesResult>>>
{
    private readonly ICatalogRepository _catalogRepository;

    public GetCatalogsWithCategoriesQueryHandler(
        ICatalogRepository catalogRepository)
    {
        _catalogRepository = catalogRepository;
    }

    public async Task<ErrorOr<IEnumerable<CatalogWithCategoriesResult>>> Handle(
        GetCatalogsWithCategoriesQuery query, 
        CancellationToken cancellationToken)
    {
        var catalogs = await _catalogRepository
            .GetCatalogsWithCategoriesAsync(cancellationToken);

        return catalogs;
    }
}
