using Microsoft.EntityFrameworkCore;
using TestProject.Shared.Entity;

namespace TestProject.Shared.Data
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext> options):base (options)
        {
                
        }
        public DbSet<Driver> Drivers { get; set; }

        public DbSet<Passanger> Passangers { get; set; }

        public DbSet<Adventure> Adventures { get; set; }
    }
}
