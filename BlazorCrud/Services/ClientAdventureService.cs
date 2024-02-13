using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using TestProject.Shared.Entity;
using TestProject.Shared.Services;

namespace BlazorCrud.Shared.Services
{
    public class ClientAdventureService : IAdventureServices
    {
        private readonly HttpClient _httpClient;
        public ClientAdventureService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        
        public Task<List<Adventure>> GetAdventures()
        {
            throw new NotImplementedException();
        }

     public async   Task<Adventure>GetAdventureById(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<Adventure> AddAdventure(Adventure adventure)
        {
            var result = await _httpClient
                 .PostAsJsonAsync("/api/adventure", adventure);
            return await result.Content.ReadFromJsonAsync<Adventure>();
        }

     public async   Task<Adventure>EditAdventure(int id, Adventure Adventure)
        {
            var result = await _httpClient
                    .PutAsJsonAsync($"/api/adventure/{id}", Adventure);
            return await result.Content.ReadFromJsonAsync<Adventure>();
        }

       public async Task<bool>DeleteAdventures(int id)
        {
            var result = await _httpClient
                      .DeleteAsync($"/api/adventure/{id}");
            return await result.Content.ReadFromJsonAsync<bool>();
        }
    }
}
