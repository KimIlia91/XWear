using XWear.Domain.EntitiesCatalog.Entities.CatalogEntity.ValueObjects;
using XWear.Domain.EntitiesCatalog.Entities.CategoryEntity;
using XWear.Domain.Common.Models;

namespace XWear.Domain.EntitiesCatalog.Entities.CatalogEntity;

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