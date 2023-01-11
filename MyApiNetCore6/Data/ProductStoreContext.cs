using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace MyApiNetCore6.Data
{
    public class ProductStoreContext : IdentityUserContext<ApplicationUser>
    {
        public ProductStoreContext (DbContextOptions<ProductStoreContext> options) : base(options)
        {
        }
        #region
        public DbSet<Make> Makes { get; set; }
        public DbSet<Size> Sizes { get; set; }
        public DbSet<BodyType> BodyTypes { get; set; }
        public DbSet<Book>? Books { get; set; }
        #endregion
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Size>().HasData(
                new Size { Id = 1, Name = "Subcompact" },
                new Size { Id = 2, Name = "Compact" },
                new Size { Id = 3, Name = "Mid Size" },
                new Size { Id = 5, Name = "Full Size" }
            );

            modelBuilder.Entity<BodyType>().HasData(
                new BodyType { Id = 1, Name = "Coupe" },
                new BodyType { Id = 2, Name = "Sedan" },
                new BodyType { Id = 3, Name = "Hatchback" },
                new BodyType { Id = 4, Name = "Wagon" },
                new BodyType { Id = 5, Name = "Convertible" },
                new BodyType { Id = 6, Name = "SUV" },
                new BodyType { Id = 7, Name = "Truck" },
                new BodyType { Id = 8, Name = "Mini Van" },
                new BodyType { Id = 9, Name = "Roadster" }
            );
        }
    }
}
