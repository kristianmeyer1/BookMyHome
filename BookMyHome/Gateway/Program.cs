using Yarp.ReverseProxy;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddReverseProxy().LoadFromConfig(builder.Configuration.GetSection("ReverseProxy"));
var app = builder.Build();

app.MapGet("/health", () => Results.Ok("OK"));
app.MapReverseProxy();

app.Run();
