namespace XWear.Domain.Entities;

public class Size : BaseEntity
{
    public string Name { get; set; } = null!;

    public ICollection<ProductSizes> ProductSizes { get; set; } = new List<ProductSizes>();
}