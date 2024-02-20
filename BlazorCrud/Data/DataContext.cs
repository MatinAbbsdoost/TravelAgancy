using Microsoft.EntityFrameworkCore;
using BlazorCrud.Shared.Entity;

namespace BlazorCrud.Shared.Data
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
