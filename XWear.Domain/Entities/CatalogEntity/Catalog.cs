using XWear.Domain.Common.Models;
using XWear.Domain.Entities.CategoryEntity;
using XWear.Domain.Entities.CatalogEntity.ValueObjects;
using XWear.Domain.Common.Constants;
using XWear.Domain.Common.Errors;
using ErrorOr;

namespace XWear.Domain.Entities.CatalogEntity;

public sealed class Catalog : Entity<CatalogId>
{
    private readonly List<Category> _categories = new();

    public string Name { get; private set; } = null!;

    public IReadOnlyCollection<Category> Categories => _categories.AsReadOnly();

    public Catalog(
        CatalogId catalogId,
        string name)
        : base(catalogId)
    {
        Name = name;
    }

    public static ErrorOr<Catalog> Create(string name)
    {
        if (string.IsNullOrEmpty(name) || name.Length > EntityConstants.CatalogNameLength)
            return Errors.Catalog.InvalidNameLength;

        return new Catalog(CatalogId.CreateUnique(), name);
    }

    public void AddCategory(Category category)
    {
        _categories.Add(category);
    }
}