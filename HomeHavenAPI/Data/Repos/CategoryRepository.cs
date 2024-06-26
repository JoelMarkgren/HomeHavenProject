﻿using HomeHavenAPI.Data.Interfaces;
using HomeHavenAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace HomeHavenAPI.Data.Repos
{
	//Author Joel,Jakob
	public class CategoryRepository : ICategory
    {
        private readonly ApplicationDbContext applicationDbContext;

        public CategoryRepository(ApplicationDbContext applicationDbContext)
        {
            this.applicationDbContext = applicationDbContext;
        }
        public async Task<Category> GetAsync(int id)
        {
            return await applicationDbContext.Categories.FindAsync(id);
        }

        public async Task<IEnumerable<Category>> GetAllAsync()
        {
            var categories = await applicationDbContext.Categories.ToListAsync();
            return categories;
        }
    }
}
