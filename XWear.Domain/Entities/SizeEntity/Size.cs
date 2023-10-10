using XWear.Domain.EntitiesCatalog.Entities.ProductEntity;
using XWear.Domain.EntitiesCatalog.Entities.SizeEntity.ValueObjects;
using XWear.Domain.Common.Models;

namespace XWear.Domain.EntitiesCatalog.Entities.SizeEntity
{
    public sealed class Size : Entity<SizeId>
    {
        private readonly List<Product> _products = new();

        public string Name { get; private set; } = null!;

        public IReadOnlyList<Product> Products => _products.AsReadOnly();

        public Size(
            SizeId sizeId,
            string name)
            : base(sizeId)
        {
            Name = name;
        }

        public static Size Create(string name)
        {
            return new(SizeId.CreateUnique(), name);
        }
    }
}
