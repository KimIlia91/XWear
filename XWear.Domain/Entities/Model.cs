namespace XWear.Domain.Entities
{
    public class Model : BaseEntity
    {
        public string Name { get; set; } = null!;

        public string ImgUrl { get; set; } = null!;

        public ICollection<Product> Products { get; set; } = new List<Product>();
    }
}