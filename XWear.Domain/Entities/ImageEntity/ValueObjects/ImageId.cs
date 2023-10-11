using XWear.Domain.Common.Models;

namespace XWear.Domain.Entities.ImageEntity.ValueObjects
{
    public sealed class ImageId : ValueObject
    {
        public Guid Value { get; private set; }

        private ImageId(Guid value)
        {
            Value = value;
        }

        public static ImageId CreateUnique()
        {
            return new(Guid.NewGuid());
        }

        public static ImageId CreateEmpty()
        {
            return new(Guid.Empty);
        }

        public static ImageId Create(Guid value)
        {
            return new(value);
        }

        public override IEnumerable<object> GetEqualityComponents()
        {
            yield return Value;
        }
    }
}
