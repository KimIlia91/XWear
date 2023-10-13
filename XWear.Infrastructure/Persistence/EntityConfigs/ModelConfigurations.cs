using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using XWear.Domain.Common.Constants;
using XWear.Domain.Entities.ColorEntity.ValueObjects;
using XWear.Domain.Entities.ModelEntity;
using XWear.Domain.Entities.ModelEntity.ValueObjects;

namespace XWear.Infrastructure.Persistence.EntityConfigs;

public sealed class ModelConfigurations : IEntityTypeConfiguration<Model>
{
    public void Configure(EntityTypeBuilder<Model> builder)
    {
        builder.ToTable("Models");

        builder.HasKey(x => x.Id);

        builder.Property(p => p.Id)
            .HasColumnName("Id")
            .ValueGeneratedNever()
            .HasConversion(
                id => id.Value,
                value => ModelId.Create(value));

        builder.Property(x => x.Name)
            .HasColumnName("Name")
            .IsRequired()
            .HasMaxLength(EntityConstants.ModelNameLength);

        builder.HasIndex(x => x.Name)
            .IsUnique();

        builder.HasMany(c => c.Products)
            .WithOne()
            .HasForeignKey(p => p.ModelId)
            .IsRequired()
            .OnDelete(DeleteBehavior.Cascade);
    }
}
