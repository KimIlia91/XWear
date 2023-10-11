using XWear.Domain.Common.Models;
using XWear.Domain.Entities.ProductEntity;
using XWear.Domain.Entities.CatalogEntity.ValueObjects;
using XWear.Domain.Entities.CategoryEntity.ValueObjects;
using XWear.Domain.Common.Constants;
using XWear.Domain.Common.Errors;
using ErrorOr;

namespace XWear.Domain.Entities.CategoryEntity;

public sealed class Category : Entity<CategoryId>
{
    private readonly List<Product> _products = new();

    public string Name { get; private set; } = null!;

    public CatalogId CatalogId { get; private set; }

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

    public static ErrorOr<Category> Create(string name, CatalogId catalogId)
    {
        if (string.IsNullOrEmpty(name) || name.Length > EntityConstants.CategoryNameLength)
            return Errors.Category.InvalidNameLength;

        return new Category(CategoryId.CreateUnique(), catalogId, name);
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }
}
