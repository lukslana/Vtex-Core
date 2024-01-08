using Microsoft.Extensions.Configuration;
using System.Net.Http;
using Vtex.Component.Api;
using Vtex.Component.Interfaces.Catalog.Brand;
using Vtex.Component.Interfaces.Catalog.Category;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

ServiceCollectionExtensions.AddVtexApiClients(builder.Services, true);

var Configuration = builder.Configuration.AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                                 .SetBasePath(AppDomain.CurrentDomain.BaseDirectory).Build();

builder.Services.Configure<VtexApi>(Configuration.GetSection("VtexApi"));
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

