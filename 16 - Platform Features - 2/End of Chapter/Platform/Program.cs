using Microsoft.AspNetCore.HostFiltering;

var builder = WebApplication.CreateBuilder(args);

builder.Services.Configure<HostFilteringOptions>(opts => {
    opts.AllowedHosts.Clear();
    opts.AllowedHosts.Add("*.example.com");
});

var app = builder.Build();

if (!app.Environment.IsDevelopment()) {
    app.UseExceptionHandler("/error.html");
    app.UseStaticFiles();
}

app.UseStatusCodePages("text/html", Platform.Responses.DefaultResponse);

app.Use(async (context, next) => {
    if (context.Request.Path == "/error") {
        context.Response.StatusCode = StatusCodes.Status404NotFound;
        await Task.CompletedTask;
    } else {
        await next();
    }
});

app.Run(context => {
    throw new Exception("Something has gone wrong");
});

app.Run();
