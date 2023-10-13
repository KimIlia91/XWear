using ErrorOr;
using XWear.Domain.Common.Constants;
using XWear.Domain.Common.Errors;
using XWear.Domain.Common.Models;
using XWear.Domain.Entities.ProductSizeEntity;
using XWear.Domain.Entities.SizeEntity.ValueObjects;

namespace XWear.Domain.Entities.SizeEntity
{
    public sealed class Size : Entity<SizeId>
    {
        private readonly List<ProductSize> _productSizes = new();

        public string Name { get; private set; } = null!;

        public IReadOnlyCollection<ProductSize> ProductSizes => _productSizes.ToList();

        private Size() : base(SizeId.CreateUnique())
        {
        }

        public Size(
            SizeId sizeId,
            string name)
            : base(sizeId)
        {
            Name = name;
        }

        public static ErrorOr<Size> Create(string name)
        {
            if (string.IsNullOrEmpty(name) || name.Length > EntityConstants.SizeNameLength)
                return Errors.Size.InvalidNameLength;

            return new Size(SizeId.CreateUnique(), name);
        }
    }
}
