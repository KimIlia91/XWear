using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using XWear.Domain.Entities.ProductEntity;
using XWear.Domain.Entities.ProductSizeEntity;
using XWear.Domain.Entities.ProductSizeEntity.ValueObjects;
using XWear.Domain.Entities.SizeEntity;

namespace XWear.Infrastructure.Persistence.EntityConfigs;

public class ProductSizeConfigurations : IEntityTypeConfiguration<ProductSize>
{
    public void Configure(EntityTypeBuilder<ProductSize> builder)
    {
        builder.ToTable("ProductSizes");

        builder.HasKey(p => p.Id);

        builder.Property(p => p.Id)
            .HasColumnName("Id")
            .ValueGeneratedNever()
            .HasConversion(
                id => id.Value,
                value => ProductSizeId.Create(value));

        builder.Property(x => x.Quantity)
            .HasColumnName("Quantity")
            .IsRequired()
            .HasConversion(
               quantity => quantity.Value,
               value => Quantity.Create(value).Value);

        builder.Property(p => p.Price)
            .HasColumnName("Price")
            .IsRequired()
            .HasConversion(
                price => price.Value,
                value => Price.Create(value).Value);

        builder.HasIndex(x => x.Price);

        builder.HasOne<Size>()
            .WithMany(s => s.ProductSizes)
            .HasForeignKey(ps => ps.SizeId)
            .IsRequired();

        builder.HasOne<Product>()
            .WithMany(s => s.ProductSizes)
            .HasForeignKey(ps => ps.ProductId)
            .IsRequired();
    }
}
