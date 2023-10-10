using XWear.Domain.Catalog.ValueObjects;
using XWear.Domain.Common.Models;

namespace XWear.Domain.Catalog.Entities;

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
