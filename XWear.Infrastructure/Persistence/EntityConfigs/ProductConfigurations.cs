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

        builder.HasOne(x => x.Size)
            .WithMany(x => x.Products)
            .IsRequired()
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasOne(x => x.Model)
            .WithMany(x => x.Products)
            .IsRequired()
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasOne(x => x.Brand)
            .WithMany(x => x.Products)
            .IsRequired()
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasOne(x => x.Category)
            .WithMany(x => x.Products)
            .IsRequired()
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasOne(x => x.Color)
            .WithMany(x => x.Products)
            .IsRequired()
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasMany(x => x.Images)
            .WithOne()
            .HasForeignKey(i => i.ProductId)
            .IsRequired()
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasMany(u => u.FavoritByUsers)
           .WithMany(p => p.FavoritProducts);
    }
}
