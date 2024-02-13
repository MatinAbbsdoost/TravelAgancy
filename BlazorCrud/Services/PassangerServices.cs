﻿using Microsoft.EntityFrameworkCore;
using TestProject.Shared.Data;
using TestProject.Shared.Entity;
using TestProject.Shared.Services;

namespace TestProject.Services
{
    public class PassangerServices : IPassnagerServices
    {
        private readonly DataContext _context;

        public PassangerServices(DataContext Context) 
        {
            _context = Context;
        }

        

     public async Task<List<Passanger>>GetPassangers()
        {
             await Task.Delay(1000);
            var passanger = await _context.Passangers.ToListAsync();
            return passanger;
        }

      public async Task<Passanger>GetPassnagerById(int id)
        {
            return await _context.Passangers.FindAsync(id);
        }

     public async Task<Passanger>AddPassnager(Passanger Passnager)
        {
            _context.Passangers.Add(Passnager);
            await _context.SaveChangesAsync();
            return Passnager;
        }

      public async  Task<Passanger>EditPassnager(int id, Passanger Passnager)
        {
            var update = await _context.Passangers.FindAsync(id);
            if (update != null)
            {
                update.FullName = Passnager.FullName;
                await _context.SaveChangesAsync();
                return update;

            }
            throw new Exception("Passangers not Found");

        }

       public async Task<bool>DeletePassnager(int id)
        {
            var delPassanger = await _context.Passangers.FindAsync(id);
            if (delPassanger != null)
            {
                _context.Remove(delPassanger);
                await _context.SaveChangesAsync();
                return true;

            }
            return false;
        }
    }
}
