﻿using HomeHavenAPI.Data.Interfaces;
using HomeHavenAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace HomeHavenAPI.Data.Repos
{
    public class BrokerageFirmRepository : IBrokerageFirm
    {
        private readonly ApplicationDbContext applicationDbContext;

        public BrokerageFirmRepository(ApplicationDbContext applicationDbContext)
        {
            this.applicationDbContext = applicationDbContext;
        }
        public async Task<BrokerageFirm> GetAsync(int id)
        {
            return await applicationDbContext.Firms.FindAsync(id);
        }

        public async Task<IEnumerable<BrokerageFirm>> GetAllAsync()
        {
            var firms = await applicationDbContext.Firms.ToListAsync();
            return firms;
        }
    }
}
