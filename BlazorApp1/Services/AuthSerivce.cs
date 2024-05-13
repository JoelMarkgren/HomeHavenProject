﻿using HomeHavenBlazorProject.Models;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json;
using System.Text;
using System.Net.Http.Headers;
using Blazored.LocalStorage;

namespace HomeHavenBlazorProject.Services
{
	public class AuthService : IAuthService
	{
		private readonly HttpClient httpClient;
        private readonly ILocalStorageService localStorage;

        public AuthService(HttpClient httpClient, ILocalStorageService localStorage)
		{
			this.httpClient = httpClient;
            this.localStorage = localStorage;
        }

		public async Task<RegisterResult> Register(RegisterModel registerModel)
		{
			var response = await httpClient.PostAsJsonAsync("api/account/register", registerModel);
			return await response.Content.ReadFromJsonAsync<RegisterResult>();
		}

		public async Task<LoginResult> Login(LoginModel loginModel)
		{
			var loginAsJson = JsonSerializer.Serialize(loginModel);
			var response = await httpClient.PostAsync("api/account/login",
				new StringContent(loginAsJson, Encoding.UTF8, "application/json"));
			var loginResult = JsonSerializer.Deserialize<LoginResult>(
				await response.Content.ReadAsStringAsync(),
				new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

			if (!response.IsSuccessStatusCode)
			{
				return loginResult;
			}

			await localStorage.SetItemAsync("Token", loginResult.Token);

			httpClient.DefaultRequestHeaders.Authorization =
				new AuthenticationHeaderValue("bearer", loginResult.Token);
			loginResult.Successful = true;



			return loginResult;
		}

		public async Task Logout()
		{
			await localStorage.RemoveItemAsync("Token");
			httpClient.DefaultRequestHeaders.Authorization = null;
		}
	}
}