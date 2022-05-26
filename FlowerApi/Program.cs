using FlowerApi.Data;
using FlowerApi.Services;
using FlowerApi.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using FlowerApi.Repositories;
using FlowerApi.Repositories.Interfaces;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddDbContext<FlowersContext>();

builder.Services.AddControllers();
builder.Services.AddScoped<IUserRepository,MockUserRepository>();
builder.Services.AddScoped<IProductRepository, ProductRepository>();
builder.Services.AddScoped<ICartService, CartService>();
builder.Services.AddScoped<IProductService, ProductService>();
builder.Services.AddSingleton<IRegisterService, RegisterService>();
builder.Services.AddSingleton<ILoginService, LoginService>();
builder.Services.AddSingleton<IHashPasswordService, HashPasswordService>();


// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
app.UseSwagger();
app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();