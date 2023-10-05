namespace XWear.Domain.Entities;

public class Catalog : BaseEntity
{
    public string Name { get; set; } = null!;

    public ICollection<Category> Categories { get; set; } = new List<Category>();
}
