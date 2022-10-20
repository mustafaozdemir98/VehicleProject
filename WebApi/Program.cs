using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Context;
using DataAccess.Concrete.EntityFramework.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

// Scope Service


builder.Services.AddScoped<ICarDal, CarDal>();
builder.Services.AddScoped<IBusDal, BusDal>();
builder.Services.AddScoped<IBoatDal, BoatDal>();


builder.Services.AddScoped<ICarService, CarService>();
builder.Services.AddScoped<IBusService, BusService>();
builder.Services.AddScoped<IBoatService, BoatService>();

// Sql Server Connection
builder.Services.AddDbContext<DatabaseContext>(x => x.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

//

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
