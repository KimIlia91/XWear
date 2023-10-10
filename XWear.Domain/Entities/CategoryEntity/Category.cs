using XWear.Domain.Common.Models;
using XWear.Domain.Entities.ProductEntity;
using XWear.Domain.Entities.CatalogEntity.ValueObjects;
using XWear.Domain.Entities.CategoryEntity.ValueObjects;

namespace XWear.Domain.Entities.CategoryEntity;

public sealed class Category : Entity<CategoryId>
{
    private readonly List<Product> _products = new();

    public string Name { get; private set; } = null!;

    public CatalogId CatalogId { get; set; }

    public IReadOnlyCollection<Product> Products => _products.AsReadOnly();

    public Category(
        CategoryId categoryId,
        CatalogId catalogId,
        string name)
        : base(categoryId)
    {
        Name = name;
        CatalogId = catalogId;
    }

    public static Category Create(string name, CatalogId catalogId)
    {
        return new(CategoryId.CreateUnique(), catalogId, name);
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }
}
