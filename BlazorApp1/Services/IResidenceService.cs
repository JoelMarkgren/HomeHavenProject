﻿using HomeHavenBlazorProject.Models;

namespace HomeHavenBlazorProject.Services
{
    public interface IResidenceService
    {
        Task<IEnumerable<Residence>> GetAllAsync();
        Task<Residence> GetAsync(int id);
        Task<Residence> CreateAsync(Residence residence);
        Task UpdateAsync(Residence residence);
        Task DeleteAsync(Residence residence);
        Task<List<Residence>> GetResidencesAsync(int realtorId);
    }
}
