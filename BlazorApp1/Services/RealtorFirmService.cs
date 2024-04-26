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

		public async Task<RealtorFirm> GetAsync(int id)
		{
			var realtorFirm = await _httpClient.GetFromJsonAsync<RealtorFirm>($"api/RealtorFirm/{id}");
			return realtorFirm;
		}
	}
}
