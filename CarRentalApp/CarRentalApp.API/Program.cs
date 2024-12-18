using CarRentalApp.API;
using CarRentalApp.Domain.Repositories;
using CarRentalApp.Domain;
using System.Reflection;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen( options =>
{
    var xmlFilename = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
    options.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory, xmlFilename));
});

builder.Services.AddScoped<IRepository<Car>, CarRepository>();
builder.Services.AddScoped<IRepository<Client>, ClientRepository>();
builder.Services.AddScoped<IRepository<RentalPlace>,  RentalPlaceRepository>();
builder.Services.AddScoped<IRepository<RentedCar>, RentedCarRepository>();

builder.Services.AddDbContext<CarRentalAppDbContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("Postgre")));

builder.Services.AddAutoMapper(typeof(Mapping));

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapControllers();

app.Run();
