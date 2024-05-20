using HomeHavenAPI.Data.Interfaces;
using HomeHavenAPI.Models;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace HomeHavenAPI.Data.Repos
{
	//Author Joel,Jakob
	public class RealtorRepository : IRealtor
	{
		private readonly ApplicationDbContext applicationDbContext;

		public RealtorRepository(ApplicationDbContext applicationDbContext)
		{
			this.applicationDbContext = applicationDbContext;
		}
		public async Task CreateAsync(Realtor realtor)
		{
			await applicationDbContext.Realtors.AddAsync(realtor);
			await applicationDbContext.SaveChangesAsync();
		}

		public async Task DeleteAsync(string id)
		{
			var realtor = await applicationDbContext.Realtors.FindAsync(id);
			if (realtor != null)
			{
				applicationDbContext.Realtors.Remove(realtor);
				await applicationDbContext.SaveChangesAsync();
			}
		}

		public async Task<Realtor> EditAsync(Realtor realtor, string id)
		{
			Realtor tempRealtor = await applicationDbContext.Realtors.FindAsync(id);
			tempRealtor.Email = realtor.Email;
			tempRealtor.RealtorFirmId = realtor.RealtorFirmId;
			tempRealtor.FirstName = realtor.FirstName;
			tempRealtor.LastName = realtor.LastName;
			tempRealtor.PhoneNumber = realtor.PhoneNumber;
			tempRealtor.ProfilePictureURL = realtor.ProfilePictureURL;
			
			applicationDbContext.Realtors.Update(tempRealtor);
			await applicationDbContext.SaveChangesAsync();
			return tempRealtor;
		}

		public async Task<Realtor> GetAsync(string id)
		{
			return await applicationDbContext.Realtors.FindAsync(id);
		}

		public async Task<IEnumerable<Realtor>> GetAllAsync()
		{
			return await applicationDbContext.Realtors.ToListAsync();
		}
	}
}
