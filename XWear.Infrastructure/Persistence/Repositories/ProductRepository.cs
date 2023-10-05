using XWear.Domain.Entities;
using XWear.Infrastructure.Persistence.Seeds;
using XWear.Application.Common.Interfaces.IRepositories;

namespace XWear.Infrastructure.Persistence.Repositories;

internal class ProductRepository : IProductRepository
{
    private readonly List<Product> _products = new();

    public ProductRepository()
    {
        if (_products.Count == 0)
        {
            _products.AddRange(ProductSeed.Seed());
        }
    }

    public IEnumerable<Product> GetAllProducts()
    {
        return _products.ToList();
    }
}
