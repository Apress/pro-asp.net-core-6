using Platform;
using Microsoft.AspNetCore.HttpLogging;
using Microsoft.Extensions.FileProviders;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddHttpLogging(opts => {
    opts.LoggingFields = HttpLoggingFields.RequestMethod
        | HttpLoggingFields.RequestPath | HttpLoggingFields.ResponseStatusCode;
});

var app = builder.Build();

app.UseHttpLogging();

app.UseStaticFiles();

var env = app.Environment;
app.UseStaticFiles(new StaticFileOptions {
    FileProvider = new
        PhysicalFileProvider($"{env.ContentRootPath}/staticfiles"),
    RequestPath = "/files"
});

app.MapGet("population/{city?}", Population.Endpoint);

app.Run();
