using XWear.Domain.Common.Enums;

namespace XWear.Domain.Entities
{
    public class Color : BaseEntity
    {
        public string Name { get; set; } = null!;

        public ColorEnum Value { get; set; }

        public virtual ICollection<Product> Products { get; set; } = new List<Product>();
    }
}