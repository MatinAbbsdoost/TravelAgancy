using TestProject.Shared.Entity;

namespace TestProject.Shared.Services
{
    public interface IPassnagerServices
    {
      Task<List<Passanger>> GetPassangers();
        Task<Passanger> GetPassnagerById(int id);
        Task<Passanger> AddPassnager(Passanger Passnager);
        Task<Passanger> EditPassnager(int id , Passanger Passnager);
        Task<bool> DeletePassanger(int id);

    }
}
