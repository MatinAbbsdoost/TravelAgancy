using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using BlazorCrud.Shared.Entity;
using BlazorCrud.Shared.Services;

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
            var result = await _httpClient
                   .GetFromJsonAsync<Adventure>($"/api/Adventure/{id}");
            return result;
        }

        public async Task<Adventure> AddAdventure(Adventure adventure)
        {
            var result = await _httpClient
                 .PostAsJsonAsync("/api/adventure", adventure);
            return await result.Content.ReadFromJsonAsync<Adventure>();
        }

     public async   Task<Adventure>EditAdventure( Adventure Adventure)
        {
            var result = await _httpClient
                    .PutAsJsonAsync($"/api/adventure/", Adventure);
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
