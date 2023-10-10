using XWear.Domain.Common.Models;
using XWear.Domain.Entities.ProductEntity;
using XWear.Domain.Entities.ColorEntity.ValueObjects;

namespace XWear.Domain.Entities.ColorEntity;

public sealed class Color : Entity<ColorId>
{
    private readonly List<Product> _products = new();

    public string Name { get; private set; } = null!;

    public IReadOnlyList<Product> Products => _products.AsReadOnly();

    public Color(
        ColorId colorId,
        string name)
        : base(colorId)
    {
        Name = name;
    }

    public static Color Create(string name)
    {
        return new(ColorId.CreateUnique(), name);
    }
}
