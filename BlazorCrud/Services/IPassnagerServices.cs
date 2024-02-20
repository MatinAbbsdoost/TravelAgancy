using BlazorCrud.Shared.Entity;

namespace BlazorCrud.Shared.Services
{
    public interface IPassnagerServices
    {
      Task<List<Passanger>> GetPassangers();
        Task<Passanger> GetPassnagerById(int id);
        Task<Passanger> AddPassnager(Passanger Passnager);
        Task<Passanger> EditPassnager( Passanger Passnager);
        Task<bool> DeletePassanger(int id);

    }
}
