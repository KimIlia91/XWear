using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using XWear.Domain.Common.Constants;
using XWear.Domain.Entities.BrandEntity;
using XWear.Domain.Entities.BrandEntity.ValueObjects;

namespace XWear.Infrastructure.Persistence.EntityConfigs;

public sealed class BrandConfigurations : IEntityTypeConfiguration<Brand>
{
    public void Configure(EntityTypeBuilder<Brand> builder)
    {
        builder.ToTable("Brands");

        builder.HasKey(x => x.Id);

        builder.Property(p => p.Id)
            .HasColumnName("Id")
            .ValueGeneratedNever()
            .HasConversion(
                id => id.Value,
                value => BrandId.Create(value));

        builder.Property(x => x.Name)
            .HasColumnName("Name")
            .IsRequired()
            .HasMaxLength(EntityConstants.BrandNameLength);

        builder.HasIndex(x => x.Name)
            .IsUnique();

        builder.HasMany(b => b.Products)
            .WithOne()
            .HasForeignKey(x => x.BrandId)
            .IsRequired()
            .OnDelete(DeleteBehavior.Cascade);
    }
}
