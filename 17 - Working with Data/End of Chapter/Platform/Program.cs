using Platform.Services;
using Platform.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDistributedSqlServerCache(opts => {
    opts.ConnectionString
        = builder.Configuration["ConnectionStrings:CacheConnection"];
    opts.SchemaName = "dbo";
    opts.TableName = "DataCache";
});

builder.Services.AddResponseCaching();
builder.Services.AddSingleton<IResponseFormatter, HtmlResponseFormatter>();

builder.Services.AddDbContext<CalculationContext>(opts => {
    opts.UseSqlServer(builder.Configuration["ConnectionStrings:CalcConnection"]);
    opts.EnableSensitiveDataLogging(true);
});

builder.Services.AddTransient<SeedData>();

var app = builder.Build();

app.UseResponseCaching();

app.MapEndpoint<Platform.SumEndpoint>("/sum/{count:int=1000000000}");

app.MapGet("/", async context => {
    await context.Response.WriteAsync("Hello World!");
});

bool cmdLineInit = (app.Configuration["INITDB"] ?? "false") == "true";
if (app.Environment.IsDevelopment() || cmdLineInit) {
    var seedData = app.Services.GetRequiredService<SeedData>();
    seedData.SeedDatabase();
}
if (!cmdLineInit) {
    app.Run();
}
