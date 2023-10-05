namespace XWear.Domain.Entities
{
    public class ProductSize : BaseEntity
    {
        public decimal Price { get; set; }

        public int Quantity { get; set; }

        public Guid ProductId { get; set; }
        public Product Product { get; set; } = null!;

        public Guid SizeId { get; set; }
        public Size Size { get; set; } = null!;
    }
}
