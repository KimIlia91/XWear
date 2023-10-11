using XWear.Domain.Common.Models;
using XWear.Domain.Entities.ProductEntity;
using XWear.Domain.Entities.ColorEntity.ValueObjects;

namespace XWear.Domain.Entities.ColorEntity;

public sealed class Color : Entity<ColorId>
{
    private readonly List<Product> _products = new();

    public string Name { get; private set; } = null!;

    public string Value { get; set; } = null!;

    public IReadOnlyCollection<Product> Products => _products.AsReadOnly();

    public Color(
        ColorId colorId,
        string name,
        string value)
        : base(colorId)
    {
        Name = name;
        Value = value;
    }

    public static Color Create(string name, string value)
    {
        return new(ColorId.CreateUnique(), name, value);
    }
}
