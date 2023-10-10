using Microsoft.EntityFrameworkCore;
using XWear.Domain.Catalog.Entities.BrandEntity;
using XWear.Domain.Catalog.Entities.CatalogEntity;
using XWear.Domain.Catalog.Entities.CategoryEntity;
using XWear.Domain.Catalog.Entities.ColorEntity;
using XWear.Domain.Catalog.Entities.FavoritParoductEntity;
using XWear.Domain.Catalog.Entities.ModelEntity;
using XWear.Domain.Catalog.Entities.ProductEntity;
using XWear.Domain.Catalog.Entities.SizeEntity;
using XWear.Domain.Catalog.Entities.UserEntity;

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
