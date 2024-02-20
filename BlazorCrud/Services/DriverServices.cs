using Microsoft.EntityFrameworkCore;
using TestProject.Shared.Data;
using TestProject.Shared.Entity;
using TestProject.Shared.Services;

namespace TestProject.Services
{
    public class DriverServices : IDriverServices
    {
        private readonly DataContext _context;

        public DriverServices(DataContext Context) 
        {
            _context = Context;
        }

        async Task<Driver> IDriverServices.AddDriver(Driver driver)
        {
         _context.Drivers.Add(driver);
            await _context.SaveChangesAsync();
            return driver;
        }

     

      public async  Task<Driver> EditDriver( Driver driver)
        {
            var update = await _context.Drivers.FindAsync();
            if (update != null)
            {
           update.FullName = driver.FullName;
              await _context.SaveChangesAsync();
                return update;

            }
            throw new Exception("Driver not Found");

        }

        async  Task<List<Driver>> IDriverServices.GetDrivers()
        {
            await Task.Delay(1000);
          var driver =  await _context.Drivers.ToListAsync();
            return driver;
        }

        async Task<Driver> IDriverServices.GetDriverById(int id)
        {
            return await _context.Drivers.FindAsync(id);
        }

       public async Task<bool>DeleteDriver(int id)
        {
            var delDriver = await _context.Drivers.FindAsync(id);
            if (delDriver != null)
            {
                _context.Remove(delDriver);
                await _context.SaveChangesAsync();
                return true;

            }
            return false;
        }
    }
}
