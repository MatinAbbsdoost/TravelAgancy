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
    public class ClientDriverService : IDriverServices
    {
        private readonly HttpClient _httpClient;
        public ClientDriverService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<Driver> AddDriver(Driver driver)
        {
            var result = await _httpClient
                .PostAsJsonAsync("/api/driver", driver);
            return await result.Content.ReadFromJsonAsync<Driver>();
        }

        public Task<List<Driver>> GetDrivers()
        {
            throw new NotImplementedException();
        }

        public async Task<Driver> GetDriverById(int id)
        {
            var result = await _httpClient
                       .GetFromJsonAsync<Driver>($"/api/game/{id}");
            return result;
        }



        public async Task<Driver> EditDriver( Driver driver)
        {
            var result = await _httpClient
                    .PutAsJsonAsync($"/api/driver/", driver);
            return await result.Content.ReadFromJsonAsync<Driver>();

        }

        public async Task<bool> DeleteDriver(int id)
        {
            var result = await _httpClient
                       .DeleteAsync($"/api/driver/{id}");
            return await result.Content.ReadFromJsonAsync<bool>();
        }
    }
}
