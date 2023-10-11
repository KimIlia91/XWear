using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using XWear.Domain.Entities.ProductEntity;
using XWear.Domain.Entities.ProductEntity.ValueObjects;

namespace XWear.Infrastructure.Persistence.EntityConfigs;

public class ProductConfigurations : IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder)
    {
        builder.ToTable("Products");

        builder.HasKey(p => p.Id);

        builder.Property(p => p.Id)
            .HasColumnName("Id")
            .ValueGeneratedNever()
            .HasConversion(
                id => id.Value,
                value => ProductId.Create(value));

        builder.Property(x => x.Quantity)
            .HasColumnName("Quantity")
            .IsRequired();

        builder.Property(p => p.Price)
            .HasColumnName("Price")
            .IsRequired();

        builder.Property(x => x.ImgUrl)
            .HasColumnName("ImageUrl")
            .IsRequired()
            .HasConversion(period => period.Name,
                name => BillingPeriod.FromName(name, true));
    }
}
