using Blazored.LocalStorage;
using HomeHavenBlazorProject;
using HomeHavenBlazorProject.Services;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

namespace BlazorApp1
{
	public class Program
	{
		public static async Task Main(string[] args)
		{
			var builder = WebAssemblyHostBuilder.CreateDefault(args);
			builder.RootComponents.Add<App>("#app");
			builder.RootComponents.Add<HeadOutlet>("head::after");

			builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://localhost:7277/") });
			builder.Services.AddScoped<IRealtorFirmService, RealtorFirmService>();
            builder.Services.AddScoped<IResidenceService, ResidenceService>();
			builder.Services.AddScoped<ICategoryService, CategoryService>();
			builder.Services.AddScoped<IRegionService, RegionService>();
            builder.Services.AddScoped<IRealtorService, RealtorService>();
			builder.Services.AddScoped<IAuthService, AuthService>();
			builder.Services.AddScoped<AuthenticationStateProvider, ApiAuthenticationStateProvider>();
			builder.Services.AddAuthorizationCore();

			builder.Services.AddBlazoredLocalStorage();

			await builder.Build().RunAsync();
		}
	}
}
