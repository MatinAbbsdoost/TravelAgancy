using TestProject.Shared.Entity;

namespace TestProject.Shared.Services
{
    public interface IDriverServices
    {
      Task<List<Driver>> GetDrivers();
        Task<Driver> GetDriverById(int id);
        Task<Driver> AddDriver(Driver driver);
        Task<Driver> EditDriver(int id , Driver driver);
        Task<bool> DeleteDriver(int id);

    }
}
