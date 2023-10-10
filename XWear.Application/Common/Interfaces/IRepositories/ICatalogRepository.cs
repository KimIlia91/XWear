using XWear.Contracts.Catalog.Responses;

namespace XWear.Application.Common.Interfaces.IRepositories;

public interface ICatalogRepository
{
    Task<IEnumerable<CatalogResponse>> GetCatalogAsync(
            CancellationToken cancellationToken);
}