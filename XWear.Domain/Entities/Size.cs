namespace XWear.Domain.Entities;

public class Size : BaseEntity
{
    public string Name { get; set; } = null!;

    public virtual ICollection<Product> ProductSizes { get; set; } = new List<Product>();
}