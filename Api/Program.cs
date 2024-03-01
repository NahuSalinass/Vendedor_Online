using Api.Funcionalities;
using Api.Funcionalities.Sellers;
using Api.Funcionalities.Stores;
using Api.Persistence;
using Carter;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddAplicationServices();
builder.Services.AddCarter();

var connectionString = builder.Configuration.GetConnectionString("aplicacion_db");

builder.Services.AddDbContext<aplicationDbContext>(opcion =>
    opcion.UseMySql(connectionString, new MySqlServerVersion(new Version(8, 0, 30))));

builder.Services.AddDbContext<aplicationDbContext>();

var opciones = new DbContextOptionsBuilder<aplicationDbContext>();

opciones.UseMySql(connectionString, new MySqlServerVersion(new Version(8, 0, 30)));

var contexto = new aplicationDbContext(opciones.Options);

contexto.Database.EnsureCreated();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(option => option.EnableTryItOutByDefault());
}

//app.AddSellersEndPoints();
//app.AddStoreEndPoints();

app.MapCarter();

app.UseHttpsRedirection();

app.Run();
