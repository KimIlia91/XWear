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

    public virtual ICollection<ProductSize> ProductSizes { get; set; } = new List<ProductSize>();

    public virtual ICollection<FavoritProduct> FavoritProducts { get; set; } = new List<FavoritProduct>();
}
