using BlazorCrud.Shared.Entity;

namespace BlazorCrud.Shared.Services
{
    public interface IDriverServices
    {
      Task<List<Driver>> GetDrivers();
        Task<Driver> GetDriverById(int id);
        Task<Driver> AddDriver(Driver driver);
        Task<Driver> EditDriver( Driver driver);
        Task<bool> DeleteDriver(int id);

    }
}
