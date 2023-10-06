namespace XWear.Domain.Entities
{
    public class Brand : BaseEntity
    {
        public string Name { get; set; } = null!;

        public virtual ICollection<Product> Products { get; set; } = new List<Product>();
    }
}