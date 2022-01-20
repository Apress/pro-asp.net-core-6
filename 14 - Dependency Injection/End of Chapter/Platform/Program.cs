//using Platform.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSingleton(typeof(ICollection<>), typeof(List<>));

var app = builder.Build();

app.MapGet("string", async context => {
    ICollection<string> collection
        = context.RequestServices.GetRequiredService<ICollection<string>>();
    collection.Add($"Request: { DateTime.Now.ToLongTimeString() }");
    foreach (string str in collection) {
        await context.Response.WriteAsync($"String: {str}\n");
    }
});

app.MapGet("int", async context => {
    ICollection<int> collection
        = context.RequestServices.GetRequiredService<ICollection<int>>();
    collection.Add(collection.Count() + 1);
    foreach (int val in collection) {
        await context.Response.WriteAsync($"Int: {val}\n");
    }
});

app.Run();
