using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using XWear.Domain.Common.Constants;
using XWear.Domain.Entities.SizeEntity.ValueObjects;
using XWear.Domain.Entities.UserEntity;
using XWear.Domain.Entities.UserEntity.ValueObjects;

namespace XWear.Infrastructure.Persistence.EntityConfigs;

public class UserConfigurations : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {

        builder.ToTable("Users");

        builder.HasKey(x => x.Id);

        builder.Property(p => p.Id)
            .HasColumnName("Id")
            .ValueGeneratedNever()
            .HasConversion(
                id => id.Value,
                value => UserId.Create(value));

        builder.Property(x => x.LastName)
            .HasColumnName("LastName")
            .IsRequired()
            .HasMaxLength(EntityConstants.LastNameLength);

        builder.Property(x => x.FirstName)
            .HasColumnName("FirstName")
            .IsRequired()
            .HasMaxLength(EntityConstants.FirstNameLength);

        builder.Property(x => x.Email)
            .HasColumnName("Email")
            .IsRequired()
            .HasMaxLength(EntityConstants.EmailLength);

        builder.HasIndex(x => x.Email)
            .IsUnique();

        builder.Property(x => x.Password)
            .HasColumnName("Password")
            .IsRequired()
            .HasMaxLength(EntityConstants.MaxPasswordLength);

        builder.HasMany(u => u.FavoritProducts)
            .WithMany(p => p.FavoritByUsers);
    }
}
