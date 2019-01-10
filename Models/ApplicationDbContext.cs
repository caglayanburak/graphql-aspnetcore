using aspnetcoregraphql;
using Microsoft.EntityFrameworkCore;

namespace GraphqlSample.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<V1> V1s { get; set; }
        public DbSet<V2> V2s { get; set; }
    }
}