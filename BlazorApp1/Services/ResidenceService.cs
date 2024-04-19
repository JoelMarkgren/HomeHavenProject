using HomeHavenAPI.Models;
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
        public async Task<IEnumerable<ResidenceDto>> GetAllAsync()
        {
            var residences = await httpClient.GetFromJsonAsync<IEnumerable<ResidenceDto>>("api/Residence");
            return residences;
        }

        public Task<Residence> GetAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
