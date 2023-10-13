using XWear.Application.Features.CatalogContext.Common;
using XWear.Contracts.Catalog.Responses;

namespace XWear.Application.Common.Interfaces.IRepositories;

public interface ICatalogRepository
{
    Task<List<CatalogResult>> GetLastUpdatedProductsByCategoryAsync(
            CancellationToken cancellationToken);

    Task<List<CatalogWithCategoriesResult>> GetCatalogsWithCategoriesAsync(
            CancellationToken cancellationToken);
}