using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using BookMyHome.Client;
using System.Net.Http.Json;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

// Base address peger på gateway (som proxier til authenticationservice)
builder.Services.AddScoped(sp =>
    new HttpClient { BaseAddress = new Uri("http://localhost:8080/") });

var app = builder.Build();

var httpClient = app.Services.GetRequiredService<HttpClient>();

async Task RegisterUser()
{
    var registerResponse = await httpClient.PostAsJsonAsync("register", new { Username = "test", Password = "123" });
    if (registerResponse.IsSuccessStatusCode)
    {
        Console.WriteLine("User registered!");
    }
    else
    {
        var error = await registerResponse.Content.ReadAsStringAsync();
        Console.WriteLine($"Registration failed: {error}");
    }
}

async Task LoginUser()
{
    var loginResponse = await httpClient.PostAsJsonAsync("login", new { Username = "test", Password = "123" });
    if (loginResponse.IsSuccessStatusCode)
    {
        Console.WriteLine("Login successful!");
    }
    else
    {
        var error = await loginResponse.Content.ReadAsStringAsync();
        Console.WriteLine($"Login failed: {error}");
    }
}

// Kald funktioner (fjern eller integrer i UI)
await RegisterUser();
await LoginUser();

await app.RunAsync();
