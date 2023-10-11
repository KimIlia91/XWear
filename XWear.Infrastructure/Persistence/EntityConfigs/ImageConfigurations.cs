using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using XWear.Domain.Common.Constants;
using XWear.Domain.Entities.ImageEntity;
using XWear.Domain.Entities.ImageEntity.ValueObjects;
using XWear.Domain.Entities.ProductEntity;

namespace XWear.Infrastructure.Persistence.EntityConfigs;

public class ImageConfigurations : IEntityTypeConfiguration<Image>
{
    public void Configure(EntityTypeBuilder<Image> builder)
    {
        builder.ToTable("Images");

        builder.HasKey(p => p.Id);

        builder.Property(p => p.Id)
            .HasColumnName("Id")
            .ValueGeneratedNever()
            .HasConversion(
                id => id.Value,
                value => ImageId.Create(value));

        builder.Property(x => x.ImgUrl)
            .HasColumnName("ImageUrl")
            .IsRequired()
            .HasMaxLength(EntityConstants.ImageUrlLength)
            .HasConversion(
               quantity => quantity.Value,
               value => ImageUrl.Create(value).Value);

        builder.HasOne<Product>()
            .WithMany(p => p.Images)
            .HasForeignKey(i => i.ProductId)
            .IsRequired()
            .OnDelete(DeleteBehavior.Cascade);
    }
}
