using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using XWear.Domain.Common.Constants;
using XWear.Domain.Entities.CatalogEntity;
using XWear.Domain.Entities.CategoryEntity;
using XWear.Domain.Entities.CategoryEntity.ValueObjects;

namespace XWear.Infrastructure.Persistence.EntityConfigs;

public sealed class CategoryConfigurations : IEntityTypeConfiguration<Category>
{
    public void Configure(EntityTypeBuilder<Category> builder)
    {
        builder.ToTable("Categories");

        builder.HasKey(x => x.Id);

        builder.Property(p => p.Id)
            .HasColumnName("Id")
            .ValueGeneratedNever()
            .HasConversion(
                id => id.Value,
                value => CategoryId.Create(value));

        builder.Property(x => x.Name)
            .HasColumnName("Name")
            .IsRequired()
            .HasMaxLength(EntityConstants.CategoryNameLength);

        builder.HasIndex(x => x.Name)
            .IsUnique();

        builder.HasOne<Catalog>()
            .WithMany(c => c.Categories)
            .HasForeignKey(c => c.CatalogId)
            .IsRequired();

        builder.HasMany(c => c.Products)
            .WithOne(p => p.Category)
            .IsRequired()
            .OnDelete(DeleteBehavior.Cascade);
    }
}
