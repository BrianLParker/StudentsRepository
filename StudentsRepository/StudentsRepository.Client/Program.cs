using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

namespace StudentsRepository.Client;

internal class Program
{
    private static async Task Main(string[] args)
    {
        var builder = WebAssemblyHostBuilder.CreateDefault(args);
        builder.Services.AddApiGenesis();

        builder.Services.AddAuthorizationCore();
        builder.Services.AddCascadingAuthenticationState();
        builder.Services.AddSingleton<AuthenticationStateProvider, PersistentAuthenticationStateProvider>();
        builder.Services.AddHttpClient(name: "HostApi", (serviceProvider, httpClient) =>
        {
            NavigationManager navigationManager = serviceProvider.GetRequiredService<NavigationManager>();
            httpClient.BaseAddress = new Uri(navigationManager.BaseUri);
        });

        await builder.Build().RunAsync();
    }
}