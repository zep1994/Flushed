using Flushed_API.Models;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.X509Certificates;


namespace Flushed_API.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) :base(options)
        {
            
        }

        public DbSet<Nutrition> Nutritions => Set<Nutrition>();
        public DbSet<IbsCount> IbsCount => Set<IbsCount>();
    }
}
