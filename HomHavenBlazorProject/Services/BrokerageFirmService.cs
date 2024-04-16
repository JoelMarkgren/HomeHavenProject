using HomHavenBlazorProject.Models;
using System.Net;
using System.Net.Http.Json;

namespace HomHavenBlazorProject.Services
{
    public class BrokerageFirmService : IBrokerageFirmService
    {
        private readonly HttpClient httpClient;

        public BrokerageFirmService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }
        public async Task<IEnumerable<BrokerageFirm>> GetAllAsync()
        {
            var firms = await httpClient.GetFromJsonAsync<IEnumerable<BrokerageFirm>>("api/BrokerageFirm");

            return firms;
        }

        public Task<BrokerageFirm> GetAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
