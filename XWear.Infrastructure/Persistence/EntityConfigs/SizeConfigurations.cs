using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using XWear.Domain.Common.Constants;
using XWear.Domain.Entities.SizeEntity;
using XWear.Domain.Entities.SizeEntity.ValueObjects;

namespace XWear.Infrastructure.Persistence.EntityConfigs;

public sealed class SizeConfigurations : IEntityTypeConfiguration<Size>
{
    public void Configure(EntityTypeBuilder<Size> builder)
    {
        builder.ToTable("Sizes");

        builder.HasKey(x => x.Id);

        builder.Property(p => p.Id)
            .HasColumnName("Id")
            .ValueGeneratedNever()
            .HasConversion(
                id => id.Value,
                value => SizeId.Create(value));

        builder.Property(x => x.Name)
            .HasColumnName("Name")
            .IsRequired()
            .HasMaxLength(EntityConstants.CategoryNameLength);

        builder.HasIndex(x => x.Name)
            .IsUnique();

        builder.HasMany(b => b.Products)
            .WithOne(p => p.Size)
            .IsRequired()
            .OnDelete(DeleteBehavior.Cascade);
    }
}
