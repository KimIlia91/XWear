using XWear.Domain.Catalog.ValueObjects;
using XWear.Domain.Common.Models;

namespace XWear.Domain.Catalog.Entities;

public sealed class Category : Entity<CategoryId>
{
    private readonly List<Product> _products = new();

    public string Name { get; private set; } = null!;

    public IReadOnlyList<Product> Products => _products.AsReadOnly();

    public Category(
        CategoryId categoryId, 
        string name) 
        : base(categoryId)
    {
        Name = name;
    }

    public static Category Create(string name)
    {
        return new(CategoryId.CreateUnique(), name);
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }
}
