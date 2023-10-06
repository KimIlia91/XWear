namespace XWear.Domain.Entities;

public class Product : BaseEntity
{
    public decimal Price { get; set; }

    public int Quantity { get; set; }

    public string ImgUrl { get; set; } = null!;

    public Guid CategoryId { get; set; }
    public Category Category { get; set; } = null!;

    public Guid BrandId { get; set; }
    public Brand Brand { get; set; } = null!;

    public Guid ColorId { get; set; }
    public Color Color { get; set; } = null!;

    public Guid ModelId { get; set; }
    public Model Model { get; set; } = null!;

    public Guid SizeId { get; set; }
    public Size Size { get; set; } = null!;

    public virtual ICollection<FavoritProduct> FavoritProducts { get; set; } = new List<FavoritProduct>();
}
