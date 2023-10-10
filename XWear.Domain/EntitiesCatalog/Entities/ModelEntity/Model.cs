using XWear.Domain.Catalog.Entities.ModelEntity.ValueObjects;
using XWear.Domain.Catalog.Entities.ProductEntity;
using XWear.Domain.Common.Models;

namespace XWear.Domain.Catalog.Entities.ModelEntity;

public sealed class Model : Entity<ModelId>
{
    private readonly List<Product> _products = new();

    public string Name { get; private set; } = null!;

    public IReadOnlyList<Product> Products => _products.AsReadOnly();

    internal Model(
        ModelId modelId,
        string name)
        : base(modelId)
    {
        Name = name;
    }

    public static Model Create(string name)
    {
        return new(ModelId.CreateUnique(), name);
    }
}
