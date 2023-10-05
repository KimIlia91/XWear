namespace XWear.Domain.Entities
{
    public class Brand : BaseEntity
    {
        public string Name { get; set; } = null!;

        public ICollection<Model> Models { get; set; } = new List<Model>();
    }
}