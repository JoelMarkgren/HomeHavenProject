using HomeHavenAPI.Data.Interfaces;
using HomeHavenAPI.Models;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace HomeHavenAPI.Data.Repos
{
	//Author Joel,Jakob
	public class ResidenceRepository : IResidence
    {
        private readonly ApplicationDbContext applicationDbContext;

        public ResidenceRepository(ApplicationDbContext applicationDbContext)
        {
            this.applicationDbContext = applicationDbContext;
        }
        public async Task<Residence> CreateAsync(Residence residence)
        {
            await applicationDbContext.Residences.AddAsync(residence);
            await applicationDbContext.SaveChangesAsync();
            return residence;
        }

        public async Task DeleteAsync(int id)
        {
            var residence = await applicationDbContext.Residences.FindAsync(id);
            if (residence != null)
            {
                applicationDbContext.Residences.Remove(residence);
                await applicationDbContext.SaveChangesAsync();
            }
        }

        public async Task<Residence> EditAsync(Residence residence)
        {
            if (residence == null)
            {
                throw new ArgumentNullException(nameof(residence));
            }
            try
            {
                var existingResidence = await applicationDbContext.Residences.FindAsync(residence.ResidenceId);
                if (existingResidence == null)
                {
                    throw new InvalidOperationException("Residence not found");
                }

                applicationDbContext.Entry(existingResidence).CurrentValues.SetValues(residence);
                await applicationDbContext.SaveChangesAsync();
                return existingResidence;
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("An error occurred while updating the residence", ex);
            }
        }

        public async Task<IEnumerable<Residence>> GetAllAsync()
        {
            return await applicationDbContext.Residences
                .Include(r => r.ResidenceCategory)
                .Include(r => r.ResidenceRegion)
                .Include(r => r.ResidenceRealtor)
                .ToListAsync();
        }

        public async Task<Residence> GetAsync(int id)
        {
            return await applicationDbContext.Residences
                .Include(r => r.ResidenceCategory)
                .Include(r => r.ResidenceRegion)
                .Include(r => r.ResidenceRealtor)
                .FirstOrDefaultAsync(r => r.ResidenceId == id);
        }
        // Lista av residences baserat på mäklare
        public async Task<List<Residence>> GetRealtorListAsync(string id)
        {
            return await applicationDbContext.Residences
                .Include(r => r.ResidenceCategory)
                .Include(r => r.ResidenceRegion)
                .Include(r => r.ResidenceRealtor)
                .Where(r => r.RealtorId == id)
                .ToListAsync();
        }
    }
}
