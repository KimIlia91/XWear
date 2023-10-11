using XWear.Domain.Common.Models;
using XWear.Domain.Entities.ProductEntity;
using XWear.Domain.Entities.ModelEntity.ValueObjects;
using XWear.Domain.Common.Constants;
using XWear.Domain.Common.Errors;
using ErrorOr;

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

    public static ErrorOr<Model> Create(string name)
    {
        if (string.IsNullOrEmpty(name) || name.Length > EntityConstants.ModelNameLength)
            return Errors.Model.InvalidNameLength;

        return new Model(ModelId.CreateUnique(), name);
    }
}
