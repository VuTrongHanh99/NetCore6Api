using Data.SqlServer.Data;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
namespace Data.SqlServer.Context
{
    public class DataContext : IdentityDbContext<ApplicationUser>
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }
        #region
        public DbSet<VBCC> VBCCs { get; set; }
        public DbSet<HocVien> HocViens { get; set; }
        public DbSet<Make> Makes { get; set; }
        public DbSet<Size> Sizes { get; set; }
        public DbSet<BodyType> BodyTypes { get; set; }
        public DbSet<Book>? Books { get; set; }
        #endregion
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Book>().HasData(
                new Book { Id = 1, Name = "Coupe", Title="1", Description="1" ,Price=1000, Quantity=10},
                new Book { Id = 2, Name = "Sedan", Title = "1", Description = "2", Price = 1000, Quantity = 10 },
                new Book { Id = 3, Name = "Hatchback" , Title = "1", Description = "3", Price = 1000, Quantity = 10 },
                new Book { Id = 4, Name = "Wagon" , Title = "1", Description = "5", Price = 1000, Quantity = 10 },
                new Book { Id = 5, Name = "Convertible" , Title = "1", Description = "4", Price = 1000, Quantity = 10 },
                new Book { Id = 6, Name = "SUV" , Title = "1", Description = "6", Price = 1000, Quantity = 10 }
            );
        }
    }
}
