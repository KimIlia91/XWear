namespace XWear.Domain.Entities;

public class Product : BaseEntity
{
    public string ImgUrl { get; set; } = null!;

    public Guid ModelId { get; set; }
    public Model Model { get; set; } = null!;

    public Guid CategoryId { get; set; }
    public Category Category { get; set; } = null!;

    public Guid BrandId { get; set; }
    public Brand Brand { get; set; } = null!;

    public Guid ColorId { get; set; }
    public Color Color { get; set; } = null!;

    public ICollection<ProductSizes> ProductSizes { get; set; } = new List<ProductSizes>();

    public ICollection<User> Users { get; set; } = new List<User>();
}
