using Microsoft.EntityFrameworkCore;
using XWear.Domain.Entities;

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
