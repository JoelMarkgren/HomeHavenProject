using HomeHavenBlazorProject.Models;
using System.Net.Http;
using System.Net.Http.Json;

namespace HomeHavenBlazorProject.Services
{
    public class ResidenceService : IResidenceService
    {
        private readonly HttpClient httpClient;

        public ResidenceService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }
        public async Task<IEnumerable<Residence>> GetAllAsync()
        {
            var residences = await httpClient.GetFromJsonAsync<IEnumerable<Residence>>("api/Residence");
            return residences;
        }

        public async Task<Residence> GetAsync(int id)
        {
            var residence = await httpClient.GetFromJsonAsync<Residence>($"api/Residence/{id}");
            return residence;
        }
    }
}
