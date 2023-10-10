using XWear.Domain.Catalog.Entities.CatalogEntity.ValueObjects;
using XWear.Domain.Catalog.Entities.CategoryEntity.ValueObjects;
using XWear.Domain.Catalog.Entities.ProductEntity;
using XWear.Domain.Common.Models;

namespace XWear.Domain.Catalog.Entities.CategoryEntity;

public sealed class Category : Entity<CategoryId>
{
    private readonly List<Product> _products = new();

    public string Name { get; private set; } = null!;

    public CatalogId CatalogId { get; set; }
    public Catalog Catalog { get; set; }

    public IReadOnlyList<Product> Products => _products.AsReadOnly();

    public Category(
        CategoryId categoryId,
        Catalog catalog,
        string name)
        : base(categoryId)
    {
        Name = name;
        CatalogId = catalog.Id;
        Catalog = catalog;
    }

    public static Category Create(string name, Catalog catalog)
    {
        return new(CategoryId.CreateUnique(), catalog, name);
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }
}
