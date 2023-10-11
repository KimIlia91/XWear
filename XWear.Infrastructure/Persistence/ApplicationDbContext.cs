using Microsoft.EntityFrameworkCore;
using XWear.Domain.Entities.BrandEntity;
using XWear.Domain.Entities.CatalogEntity;
using XWear.Domain.Entities.CategoryEntity;
using XWear.Domain.Entities.ColorEntity;
using XWear.Domain.Entities.ModelEntity;
using XWear.Domain.Entities.ProductEntity;
using XWear.Domain.Entities.SizeEntity;
using XWear.Domain.Entities.UserEntity;

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

        public DbSet<Color> Colors { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);
        }
    }
}
