using Microsoft.EntityFrameworkCore;
using MiniShop.Api.Application.Products.GetProducts;
using MiniShop.Api.Application.Products.CreateProduct;
using MiniShop.Api.Domain.Repositories;
using MiniShop.Api.Infrastructure.Persistence;
using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddScoped<GetProductsHandler>();
builder.Services.AddScoped<CreateProductHandler>();
builder.Services.AddScoped<IProductRepository, PostgresProductRepository>();
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseNpgsql(
        "Host=localhost;Port=5432;Database=minishop;Username=minishop;Password=minishop"));

var app = builder.Build();

app.MapControllers();

app.MapGet("/", async ([FromServices] AppDbContext db) =>
{
    var canConnect = await db.Database.CanConnectAsync();

    return Results.Ok(new
    {
        Connected = canConnect
    });
});

app.Run();