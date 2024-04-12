﻿using HomeHavenAPI.Models;

namespace HomeHavenAPI.Data.Interfaces
{
    public interface IResidence
    {
        Task<Residence> GetAsync(int id);
        Task<IEnumerable<Residence>> GetAllAsync();
        Task<Residence> EditAsync(Residence residence);
        Task DeleteAsync(int id);
        Task CreateAsync(Residence residence);
    }
}
