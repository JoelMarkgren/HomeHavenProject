using HomeHavenBlazorProject.Models;
using System.Net.Http.Json;

namespace HomeHavenBlazorProject.Services
{
    public class RealtorService : IRealtorService
    {
        private readonly HttpClient httpClient;

        public RealtorService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }
        public Task<Realtor> CreateAsync()
        {
            try
            {
                var realtor = httpClient.GetFromJsonAsync<Realtor>("api/Realtor");
            }
            catch (Exception ex)
            {
                throw;
            }
            return null;
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Realtor>> GetAllAsync()
        {
            try
            {
                var realtors = await httpClient.GetFromJsonAsync<IEnumerable<Realtor>>("api/Realtor");
                return realtors;
            }
            catch
            {
                throw;
            }
            
        }

        public Task<Realtor> GetAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}

