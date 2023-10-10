using Microsoft.EntityFrameworkCore;
using XWear.Domain.EntitiesCatalog.Entities.BrandEntity;
using XWear.Domain.EntitiesCatalog.Entities.CatalogEntity;
using XWear.Domain.EntitiesCatalog.Entities.CategoryEntity;
using XWear.Domain.EntitiesCatalog.Entities.ColorEntity;
using XWear.Domain.EntitiesCatalog.Entities.FavoritParoductEntity;
using XWear.Domain.EntitiesCatalog.Entities.ModelEntity;
using XWear.Domain.EntitiesCatalog.Entities.ProductEntity;
using XWear.Domain.EntitiesCatalog.Entities.SizeEntity;
using XWear.Domain.EntitiesCatalog.Entities.UserEntity;

namespace XWear.Infrastructure.Persistence
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        public DbSet<Brand> Brands { get; set; }

        public DbSet<Model> Models { get; set; }

        public DbSet<Size> Sizes { get; set; }

        public DbSet<Catalog> Catalogs { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<User> Users { get; set; }

        public DbSet<FavoritProduct> FavoritProducts { get; set; }

        public DbSet<Color> Colors { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
    }
}
