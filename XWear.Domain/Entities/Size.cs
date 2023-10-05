namespace XWear.Domain.Entities;

public class Size : BaseEntity
{
    public string Name { get; set; } = null!;

    public virtual ICollection<ProductSize> ProductSizes { get; set; } = new List<ProductSize>();
}