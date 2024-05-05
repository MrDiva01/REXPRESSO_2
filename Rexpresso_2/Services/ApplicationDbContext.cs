using Microsoft.EntityFrameworkCore;
using Rexpresso_2.Models;

namespace Rexpresso_2.Services
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) :base(options)
        {

        }
        public DbSet<Product> Products { get; set; }

    }
}
