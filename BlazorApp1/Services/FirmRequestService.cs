using HomeHavenBlazorProject.Models;
using HomeHavenBlazorProject.Pages.Realtor;
using System.Net.Http.Json;

namespace HomeHavenBlazorProject.Services
{
	public class FirmRequestService : IFirmRequestService
	{
		private readonly HttpClient httpClient;

		public FirmRequestService(HttpClient httpClient)
        {
			this.httpClient = httpClient;
		}
        public async Task<FirmRequest> CreateAsync(FirmRequest firmRequest)
		{
			var response = await httpClient.PostAsJsonAsync("api/FirmRequest", firmRequest);
			response.EnsureSuccessStatusCode();
			return await response.Content.ReadFromJsonAsync<FirmRequest>();
		}

		public async Task DeleteAsync(int id)
		{
			var response = await httpClient.DeleteAsync($"api/FirmRequest/{id}");
			response.EnsureSuccessStatusCode();
		}

		public async Task<IEnumerable<FirmRequest>> GetAllInivtesAsync(string email)
		{
			var invites = await httpClient.GetFromJsonAsync<IEnumerable<FirmRequest>>($"api/FirmRequest/GetRequests/{email}");
			return invites;
		}

		public async Task<IEnumerable<FirmRequest>> GetAllRequestsAsync(string email)
		{
			var invites = await httpClient.GetFromJsonAsync<IEnumerable<FirmRequest>>($"api/FirmRequest/GetInvites/{email}");
			return invites;
		}
	}
}
