using XWear.Application.Features.CatalogContext.Common;

namespace XWear.Application.Common.Interfaces.IRepositories;

public interface ICatalogRepository
{
    Task<List<CatalogResult>> GetLastUpdatedProductsByCategoryAsync(
            CancellationToken cancellationToken);

    Task<List<CatalogWithCategoriesResult>> GetCatalogsWithCategoriesAsync(
            CancellationToken cancellationToken);
}