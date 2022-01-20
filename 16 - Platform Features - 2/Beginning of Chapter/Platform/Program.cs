var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

app.MapFallback(async context =>
    await context.Response.WriteAsync("Hello World!"));

app.Run();
