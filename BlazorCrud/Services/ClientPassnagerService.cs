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
    public class ClientPassnagerService : IPassnagerServices
    {
        private readonly HttpClient _httpClient;
        public ClientPassnagerService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
       
        Task<List<Passanger>> IPassnagerServices.GetPassangers()
        {
            throw new NotImplementedException();
        }

     public async Task<Passanger>GetPassnagerById(int id)
        {
            var result = await _httpClient
                    .GetFromJsonAsync<Passanger>($"/api/passnanger/{id}");
            return result;
        }

     public async Task<Passanger>AddPassnager(Passanger Passnager)
        {
            var result = await _httpClient
                .PostAsJsonAsync("/api/passanger", Passnager);
            return await result.Content.ReadFromJsonAsync<Passanger>();
        }

     public async Task<Passanger>EditPassnager( Passanger Passnager)
        {
            var result = await _httpClient
                    .PutAsJsonAsync($"/api/Passnager/", Passnager);
            return await result.Content.ReadFromJsonAsync<Passanger>();
        }

       public async Task<bool>DeletePassnager(int id)
        {
            var result = await _httpClient
                       .DeleteAsync($"/api/passnager/{id}");
            return await result.Content.ReadFromJsonAsync<bool>();
        }

        public Task<bool> DeletePassanger(int id)
        {
            throw new NotImplementedException();
        }
    }
}
