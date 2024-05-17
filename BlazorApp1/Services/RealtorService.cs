using HomeHavenBlazorProject.Models;
using System.Net.Http.Json;
using System.Reflection.PortableExecutable;

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

        public async Task<Realtor> GetAsync(string id)
        {
			var realtor = await httpClient.GetFromJsonAsync<Realtor>($"api/Realtor/{id}");
			return realtor;
		}

        public async Task UpdateAsync(Realtor realtor, string id)
        {
            var respons = await httpClient.PutAsJsonAsync($"api/Realtor/{id}", realtor);
        }
    }
}

