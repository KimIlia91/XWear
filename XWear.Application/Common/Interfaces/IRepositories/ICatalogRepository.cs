using XWear.Domain.Entities;

namespace XWear.Application.Common.Interfaces.IRepositories;

public interface ICatalogRepository
{
    Task<IEnumerable<Catalog>> GetCatalogsAsync(CancellationToken cancellationToken);
}
