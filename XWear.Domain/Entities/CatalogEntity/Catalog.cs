using XWear.Domain.Common.Models;
using XWear.Domain.Entities.CategoryEntity;
using XWear.Domain.Entities.CatalogEntity.ValueObjects;

namespace XWear.Domain.Entities.CatalogEntity;

public sealed class Catalog : Entity<CatalogId>
{
    private readonly List<Category> _categories = new();

    public string Name { get; private set; } = null!;

    public IReadOnlyList<Category> Categories => _categories.AsReadOnly();

    public Catalog(
        CatalogId catalogId,
        string name)
        : base(catalogId)
    {
        Name = name;
    }

    public static Catalog Create(string name)
    {
        return new(CatalogId.CreateUnique(), name);
    }

    public void AddCategory(Category category)
    {
        _categories.Add(category);
    }
}