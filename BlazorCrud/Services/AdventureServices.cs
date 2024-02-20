using Microsoft.EntityFrameworkCore;
using TestProject.Shared.Data;
using TestProject.Shared.Entity;
using TestProject.Shared.Services;

namespace TestProject.Services
{
    public class AdventureServices : IAdventureServices
    {
        private readonly DataContext _context;

        public AdventureServices(DataContext Context) 
        {
            _context = Context;
        }
       public async Task<List<Adventure>>GetAdventures()
        {
            await Task.Delay(1000);
            var adventures = await _context.Adventures.ToListAsync();
            return adventures;
        }

      public async Task<Adventure>GetAdventureById(int id)
        {
            return await _context.Adventures.FindAsync(id);
        }

       public async Task<Adventure>AddAdventure(Adventure adventure)
        {
            _context.Adventures.Add(adventure);
            await _context.SaveChangesAsync();
            return adventure;
        }

       public async Task<Adventure>EditAdventure( Adventure Adventure)
        {
            var update = await _context.Adventures.FindAsync();
            if (update != null)
            {
                update.DriverId = Adventure.DriverId;
                update.PassangerId = Adventure.PassangerId;
                await _context.SaveChangesAsync();
                return update;

            }
            throw new Exception("Addventure not Found");

        }

      public async  Task<bool>DeleteAdventures(int id)
        {
            var DelAdventure = await _context.Adventures.FindAsync(id);
            if (DelAdventure != null)
            {
                _context.Remove(DelAdventure);
                await _context.SaveChangesAsync();
                return true;

            }
            return false;
        }
    }
}
