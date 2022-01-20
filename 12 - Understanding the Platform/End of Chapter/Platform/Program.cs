//using Microsoft.Extensions.Options;
using Platform;

var builder = WebApplication.CreateBuilder(args);

builder.Services.Configure<MessageOptions>(options => {
    options.CityName = "Albany";
});

var app = builder.Build();

app.UseMiddleware<LocationMiddleware>();

app.MapGet("/", () => "Hello World!");

app.Run();
