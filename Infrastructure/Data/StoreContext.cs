using Microsoft.EntityFrameworkCore;
using Core.Entities;

namespace Infrastructure.Data
{
    public class StoreContext : DbContext
    {
        public StoreContext(DbContextOptions<StoreContext> options) : base(options)
        {
        }

        // Dbset allows us to use the context to access the table Products
        // and run queries to fetch data from the database
        public DbSet<Product> Products { get; set; }
    }
}