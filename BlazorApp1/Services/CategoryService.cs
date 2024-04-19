using HomeHavenBlazorProject.Models;
using Microsoft.VisualBasic;
using System.Net.Http.Json;

namespace HomeHavenBlazorProject.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly HttpClient httpClient;

        public CategoryService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }
        public async Task<IEnumerable<Category>> GetAllAsync()
        {
            try
            {
                var categories = await httpClient.GetFromJsonAsync<IEnumerable<Category>>("api/Category");
                return categories;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public async Task<Category> GetAsync(int id)
        {
            var category = await httpClient.GetFromJsonAsync<Category>($"api/Category/{id}");
            return category;
        }
    }
}
