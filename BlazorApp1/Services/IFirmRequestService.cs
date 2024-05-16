using HomeHavenBlazorProject.Models;
using HomeHavenBlazorProject.Pages.Realtor;

namespace HomeHavenBlazorProject.Services
{
	public interface IFirmRequestService
	{
		Task<IEnumerable<FirmRequest>> GetAllInivtesAsync(string email);
		Task<IEnumerable<FirmRequest>> GetAllRequestsAsync(string email);
		Task DeleteAsync(int id);
		Task<FirmRequest> CreateAsync(FirmRequest firmRequest);
	}
}
