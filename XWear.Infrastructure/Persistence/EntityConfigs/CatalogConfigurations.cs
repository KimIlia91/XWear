using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using XWear.Domain.Common.Constants;
using XWear.Domain.Entities.CatalogEntity;
using XWear.Domain.Entities.CatalogEntity.ValueObjects;

namespace XWear.Infrastructure.Persistence.EntityConfigs
{
    internal class CatalogConfigurations : IEntityTypeConfiguration<Catalog>
    {
        public void Configure(EntityTypeBuilder<Catalog> builder)
        {
            builder.ToTable("Catalogs");

            builder.HasKey(x => x.Id);

            builder.Property(p => p.Id)
                .HasColumnName("Id")
                .ValueGeneratedNever()
                .HasConversion(
                    id => id.Value,
                    value => CatalogId.Create(value));

            builder.Property(x => x.Name)
                .HasColumnName("Name")
                .IsRequired()
                .HasMaxLength(EntityConstants.CatalogNameLength);

            builder.HasIndex(x => x.Name)
                .IsUnique();

            builder.HasMany(c => c.Categories)
                .WithOne()
                .HasForeignKey(c => c.CatalogId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
