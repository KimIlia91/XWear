using XWear.Domain.Entities;

namespace XWear.Application.Common.Interfaces;

public interface IProductRepository
{
    IEnumerable<Product> GetAllProducts();
}
