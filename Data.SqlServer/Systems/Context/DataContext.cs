using Data.SqlServer.Data;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
namespace Data.SqlServer.Context
{
    public class DataContext : IdentityUserContext<ApplicationUser>
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
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
                new Size { Id = 1, Code = "Subcompact" },
                new Size { Id = 2, Code = "Compact" },
                new Size { Id = 3, Code = "Mid Size" },
                new Size { Id = 5, Code = "Full Size" }
            );

            modelBuilder.Entity<BodyType>().HasData(
                new BodyType { Id = 1, Code = "Coupe" },
                new BodyType { Id = 2, Code = "Sedan" },
                new BodyType { Id = 3, Code = "Hatchback" },
                new BodyType { Id = 4, Code = "Wagon" },
                new BodyType { Id = 5, Code = "Convertible" },
                new BodyType { Id = 6, Code = "SUV" },
                new BodyType { Id = 7, Code = "Truck" },
                new BodyType { Id = 8, Code = "Mini Van" },
                new BodyType { Id = 9, Code = "Roadster" }
            );
        }
    }
}
