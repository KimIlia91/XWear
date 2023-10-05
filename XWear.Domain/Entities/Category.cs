namespace XWear.Domain.Entities
{
    public class Category : BaseEntity
    {
        public string Name { get; set; } = null!;

        public Guid CatalogId { get; set; }
        public Catalog Catalog { get; set; } = null!;

        public ICollection<Product> Products { get; set; } = new List<Product>();
    }
}