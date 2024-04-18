using HomeHavenBlazorProject;
using HomeHavenBlazorProject.Services;
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
			builder.Services.AddScoped<IBrokerageFirmService, BrokerageFirmService>();
            builder.Services.AddScoped<IResidenceService, ResidenceService>();

            await builder.Build().RunAsync();
		}
	}
}
