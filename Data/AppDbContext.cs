using Microsoft.EntityFrameworkCore;
using InstMigg.Models;

namespace InstMigg.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Installs> Installs { get; set; }
        public DbSet<Migrations> Migrations { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }
    }
}