using XWear.Contracts.Catalog.Responses;

namespace XWear.Application.Common.Interfaces.IRepositories;

public interface ICatalogRepository
{
    Task<List<CatalogResponse>> GetLastUpdatedProductsByCategoryAsync(
            CancellationToken cancellationToken);
}