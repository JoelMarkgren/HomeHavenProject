﻿using HomeHavenBlazorProject.Models;
using System.Net;
using System.Net.Http;
using System.Net.Http.Json;

namespace HomeHavenBlazorProject.Services
{
    public class ResidenceService : IResidenceService
    {
        private readonly HttpClient httpClient;

        public ResidenceService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<Residence> CreateAsync(Residence residence)
        {
            var response = await httpClient.PostAsJsonAsync("api/Residence", residence);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<Residence>();
        }

        public async Task DeleteAsync(Residence residence)
        {
            var response = await httpClient.DeleteAsync($"api/Residence/{residence.ResidenceId}");
            response.EnsureSuccessStatusCode();

        }

        public async Task<IEnumerable<Residence>> GetAllAsync()
        {
            var residences = await httpClient.GetFromJsonAsync<IEnumerable<Residence>>("api/Residence");
            return residences;
        }

        public async Task<Residence> GetAsync(int id)
        {
            var residence = await httpClient.GetFromJsonAsync<Residence>($"api/Residence/{id}");
            return residence;
        }

        public async Task UpdateAsync(Residence residence)
        {
            var response = await httpClient.PutAsJsonAsync($"api/Residence/{residence.ResidenceId}", residence);
            response.EnsureSuccessStatusCode();
        }
        public async Task<List<Residence>> GetResidencesAsync(int realtorId)
        {
            var response = await httpClient.GetFromJsonAsync<List<Residence>>($"api/Residence/{realtorId}");
            return response;
        }
    }
}
