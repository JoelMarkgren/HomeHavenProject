using HomeHavenBlazorProject.Models;
using System.Net;
using System.Net.Http.Json;

namespace HomeHavenBlazorProject.Services
{
	public class RealtorFirmService : IRealtorFirmService
	{
		private readonly HttpClient _httpClient;

		public RealtorFirmService(HttpClient httpClient)
		{
			_httpClient = httpClient;
		}
		public async Task<IEnumerable<RealtorFirm>> GetAllAsync()
		{
			try
			{
				var firms = await _httpClient.GetFromJsonAsync<IEnumerable<RealtorFirm>>("api/RealtorFirm");
				return firms;
			}
			catch (Exception)
			{
				throw;
			}

		}

		public Task<RealtorFirm> GetAsync(int id)
		{
			throw new NotImplementedException();
		}
	}
}
