using Platform;
using Platform.Services;

var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

app.UseMiddleware<WeatherMiddleware>();

IResponseFormatter formatter = new TextResponseFormatter();
app.MapGet("middleware/function", async (context) => {
    await formatter.Format(context, "Middleware Function: It is snowing in Chicago");
});

app.MapGet("endpoint/class", WeatherEndpoint.Endpoint);

app.MapGet("endpoint/function", async context => {
    await context.Response.WriteAsync("Endpoint Function: It is sunny in LA");
});

app.Run();
