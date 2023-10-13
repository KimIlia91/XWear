using XWear.Domain.Common.Models;

namespace XWear.Domain.Entities.ProductSizeEntity.ValueObjects
{
    public sealed class ProductSizeId : ValueObject
    {
        public Guid Value { get; private set; }

        private ProductSizeId(Guid value)
        {
            Value = value;
        }

        public static ProductSizeId CreateUnique()
        {
            return new(Guid.NewGuid());
        }

        public static ProductSizeId Create(Guid value)
        {
            return new(value);
        }

        public override IEnumerable<object> GetEqualityComponents()
        {
            yield return Value;
        }
    }
}
