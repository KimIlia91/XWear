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

        builder.HasOne(p => p.Model)
            .WithMany(m => m.Products)
            .IsRequired()
            .HasForeignKey(x => x.ModelId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasOne(p => p.Brand)
            .WithMany(x => x.Products)
            .IsRequired()
            .HasForeignKey(x => x.BrandId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasOne(p => p.Category)
            .WithMany(x => x.Products)
            .IsRequired()
            .HasForeignKey(x => x.CategoryId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasOne(p => p.Color)
            .WithMany(x => x.Products)
            .IsRequired()
            .HasForeignKey(x => x.ColorId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasMany(x => x.Images)
            .WithOne()
            .HasForeignKey(i => i.ProductId)
            .IsRequired()
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasMany(x => x.ProductSizes)
            .WithOne()
            .HasForeignKey(ps => ps.ProductId)
            .IsRequired()
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasMany(u => u.FavoritByUsers)
            .WithMany(p => p.FavoritProducts);
    }
}
