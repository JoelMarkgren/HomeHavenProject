using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components.Authorization;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace HomeHavenBlazorProject
{
	public class ApiAuthenticationStateProvider : AuthenticationStateProvider
	{
		//Author Joel, Jakob
		private readonly ILocalStorageService localStorage;
		private readonly HttpClient httpClient;

		public ApiAuthenticationStateProvider(HttpClient httpClient, ILocalStorageService localStorage)
        {
			this.httpClient = httpClient;
			this.localStorage = localStorage;
		}

		public override async Task<AuthenticationState> GetAuthenticationStateAsync()
		{
			var savedToken = await localStorage.GetItemAsync<string>("Token");

			if (string.IsNullOrWhiteSpace(savedToken))
			{
				return new AuthenticationState(new ClaimsPrincipal(
					new ClaimsIdentity()));
			}
			var handler = new JwtSecurityTokenHandler();
			var token = handler.ReadJwtToken(savedToken);


			var claims = token.Claims.Select(c => new Claim(c.Type, c.Value));

			var identity = new ClaimsIdentity(claims, "jwt");

			var user = new ClaimsPrincipal(identity);

			return new AuthenticationState(new ClaimsPrincipal(identity));
		}

		public void MarkUserAsAuthenticated(string email)
		{
			var authenticatedUser = new ClaimsPrincipal(new ClaimsIdentity(new[]
				{ new Claim(ClaimTypes.Name, email) }, "apiauth"));
			var authState = Task.FromResult(new AuthenticationState(authenticatedUser));
			NotifyAuthenticationStateChanged(authState);
		}

		public void MarkUserAsLoggedOut()
		{
			var anonymousUser = new ClaimsPrincipal(new ClaimsIdentity());
			var authState = Task.FromResult(new AuthenticationState(anonymousUser));
			NotifyAuthenticationStateChanged(authState);
		}
	}
}
