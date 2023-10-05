using XWear.Domain.Entities;

namespace XWear.Application.Common.Interfaces.IRepositories;

public interface IProductRepository
{
    IEnumerable<Product> GetAllProducts();
}
