using Crud_Operation_Practice.Models;
using Microsoft.EntityFrameworkCore;

namespace Crud_Operation_Practice.DataContext
{
    public class databaseContext : DbContext
    {
        public databaseContext(DbContextOptions<databaseContext> options)
        : base(options)
        {
        }
        public DbSet<Product> Products { get; set; }
    }
}
