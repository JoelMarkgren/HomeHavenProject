using HomeHavenBlazorProject.Models;
using System.Net;
using System.Net.Http.Json;

namespace HomeHavenBlazorProject.Services
{
	public class BrokerageFirmService : IBrokerageFirmService
	{
		private readonly HttpClient _httpClient;

		public BrokerageFirmService(HttpClient httpClient)
		{
			_httpClient = httpClient;
		}
		public async Task<IEnumerable<BrokerageFirm>> GetAllAsync()
		{
			try
			{
				var firms = await _httpClient.GetFromJsonAsync<IEnumerable<BrokerageFirm>>("api/BrokerageFirm");
				return firms;
			}
			catch (Exception)
			{
				throw;
			}





		}

		public Task<BrokerageFirm> GetAsync(int id)
		{
			throw new NotImplementedException();
		}
	}
}
