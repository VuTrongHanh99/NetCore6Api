using Microsoft.EntityFrameworkCore;

namespace MyApiNetCore6.Data
{
    public class BookStoreContext : DbContext
    {
        public BookStoreContext(DbContextOptions<BookStoreContext> options) : base(options)
        {

        }
        #region
        public DbSet<Book>? Books { get; set; }
        #endregion
    }
}
