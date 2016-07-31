using System.IO;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

public class Program {

	public static void Main(string[] args) {
		var host = new WebHostBuilder()
			.UseContentRoot(Directory.GetCurrentDirectory())
			.UseStartup<Program>()
			.UseKestrel()
			.Build();

		host.Run();
	}

	public void ConfigureServices(IServiceCollection services) {
		services.AddMvc();
	}

	public void Configure(IApplicationBuilder app) {
		app.UseMvcWithDefaultRoute();
	}
}
