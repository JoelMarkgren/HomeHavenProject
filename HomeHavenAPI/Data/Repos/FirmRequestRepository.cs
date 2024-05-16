using HomeHavenAPI.Data.Interfaces;
using HomeHavenAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace HomeHavenAPI.Data.Repos
{
	public class FirmRequestRepository : IFirmRequest
	{
		private readonly ApplicationDbContext applicationDbContext;

		public FirmRequestRepository(ApplicationDbContext appplicationDbContext)
        {
			this.applicationDbContext = appplicationDbContext;
		}
        public async Task CreateAsync(FirmRequest firmRequest)
		{
			await applicationDbContext.FirmRequests.AddAsync(firmRequest);
			await applicationDbContext.SaveChangesAsync();
		}

		public async Task DeleteAsync(int id)
		{
			var request = await applicationDbContext.FirmRequests.FindAsync(id);
			if (request != null)
			{
				applicationDbContext.FirmRequests.Remove(request);
				await applicationDbContext.SaveChangesAsync();
			}
		}

		public async Task<IEnumerable<FirmRequest>> GetAllInivtesAsync(string email)
		{
			return await applicationDbContext.FirmRequests.Where(r => r.ToEmail == email).ToListAsync();
		}

		public async Task<IEnumerable<FirmRequest>> GetAllRequestsAsync(string email)
		{
			return await applicationDbContext.FirmRequests.Where(r => r.FromEmail == email).ToListAsync();
		}

	}
}
