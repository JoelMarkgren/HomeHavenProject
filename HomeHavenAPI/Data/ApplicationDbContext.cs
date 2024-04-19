using HomeHavenAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace HomeHavenAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Realtor> Realtors { get; set; }
        public DbSet<RealtorFirm> Firms { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Region> Regions { get; set; }
        public DbSet<Residence> Residences { get; set; }

    }
}
