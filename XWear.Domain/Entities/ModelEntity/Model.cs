using XWear.Domain.Common.Models;
using XWear.Domain.Entities.ProductEntity;
using XWear.Domain.Entities.ModelEntity.ValueObjects;

namespace XWear.Domain.Entities.ModelEntity;

public sealed class Model : Entity<ModelId>
{
    private readonly List<Product> _products = new();

    public string Name { get; private set; } = null!;

    public IReadOnlyCollection<Product> Products => _products.AsReadOnly();

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
