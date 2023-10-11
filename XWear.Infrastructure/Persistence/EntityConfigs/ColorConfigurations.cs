using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using XWear.Domain.Common.Constants;
using XWear.Domain.Common.Enums;
using XWear.Domain.Entities.ColorEntity;
using XWear.Domain.Entities.ColorEntity.ValueObjects;

namespace XWear.Infrastructure.Persistence.EntityConfigs
{
    public sealed class ColorConfigurations : IEntityTypeConfiguration<Color>
    {
        public void Configure(EntityTypeBuilder<Color> builder)
        {
            builder.ToTable("Colors");

            builder.HasKey(x => x.Id);

            builder.Property(p => p.Id)
                .HasColumnName("Id")
                .ValueGeneratedNever()
                .HasConversion(
                    id => id.Value,
                    value => ColorId.Create(value));

            builder.Property(x => x.Name)
                .HasColumnName("Name")
                .IsRequired()
                .HasMaxLength(EntityConstants.ColorNameLength);

            builder.HasIndex(x => x.Name)
                .IsUnique();

            builder.Property(x => x.Value)
                .HasConversion(new EnumToStringConverter<ColorEnum>())
                .IsRequired()
                .HasMaxLength(EntityConstants.ColorNameLength);

            builder.HasMany(c => c.Products)
                .WithOne(p => p.Color)
                .IsRequired()
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
