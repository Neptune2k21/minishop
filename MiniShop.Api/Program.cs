var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

app.MapGet("/", () =>
{
    return "MiniShop API";
});

app.MapGet("/hello", () =>
{
    return "Hello from MiniShop!";
});

app.Run();