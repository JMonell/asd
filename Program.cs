using BlazorApi2.Services;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

namespace BlazorApi2;

public class Program
{
    public static async Task Main(string[] args)
    {
        var builder = WebAssemblyHostBuilder.CreateDefault(args);
        builder.RootComponents.Add<App>("#app");
        builder.RootComponents.Add<HeadOutlet>("head::after");

        builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

        var apiKey = builder.Configuration["ApiKey"];
        builder.Services.AddSingleton(new ApiService(apiKey));
        builder.Services.AddSingleton(new NumberService());



        await builder.Build().RunAsync();
    }
}
