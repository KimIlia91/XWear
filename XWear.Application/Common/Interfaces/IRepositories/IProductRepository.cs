using XWear.Domain.Entities;

namespace XWear.Application.Common.Interfaces.IRepositories;

public interface IProductRepository
{
    Task<IEnumerable<Product>> GetAllProductsAsync(CancellationToken cancellationToken);
}
