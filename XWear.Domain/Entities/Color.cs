namespace XWear.Domain.Entities
{
    public class Color : BaseEntity
    {
        public string Name { get; set; } = null!;

        public string Value { get; set; } = null!;

        public ICollection<Product> Products { get; set; } = new List<Product>();
    }
}