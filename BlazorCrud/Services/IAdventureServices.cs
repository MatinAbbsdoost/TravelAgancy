using TestProject.Shared.Entity;

namespace TestProject.Shared.Services
{
    public interface IAdventureServices
    {
      Task<List<Adventure>> GetAdventures();
        Task<Adventure> GetAdventureById(int id);
        Task<Adventure> AddAdventure(Adventure driver);
        Task<Adventure> EditAdventure( Adventure Adventure);
        Task<bool> DeleteAdventures(int id);

    }
}
