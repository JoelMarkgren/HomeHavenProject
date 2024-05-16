using HomeHavenAPI.Models;

namespace HomeHavenAPI.Data.Interfaces
{
	public interface IFirmRequest
	{
		Task<IEnumerable<FirmRequest>> GetAllInivtesAsync(string email);
		Task<IEnumerable<FirmRequest>> GetAllRequestsAsync(string email);
		Task DeleteAsync(int id);
		Task CreateAsync(FirmRequest firmRequest);
	}
}
