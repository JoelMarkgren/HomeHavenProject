using HomeHavenBlazorProject.Models;
using System.Net.Http;
using System.Net.Http.Json;

namespace HomeHavenBlazorProject.Services
{
    public class RegionService : IRegionService
    {
		//Author Joel, Jakob
		private readonly HttpClient httpClient;

        public RegionService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }
        public async Task<IEnumerable<Region>> GetAllAsync()
        {
            try
            {
                var regions = await httpClient.GetFromJsonAsync<IEnumerable<Region>>("api/Region");
                return regions;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public async Task<Region> GetAsync(int id)
        {
            var region = await httpClient.GetFromJsonAsync<Region>($"api/Region/{id}");
            return region;
        }
    }
}
