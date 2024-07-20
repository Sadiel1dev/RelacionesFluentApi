using System.Reflection.Metadata;
using System;
using System.Collections.Immutable;
using Infraestructura.Data;
using Microsoft.EntityFrameworkCore;
using API.Helper;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddAutoMapper(typeof(Mapping));
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
var conexion=builder.Configuration.GetConnectionString("conexion");
builder.Services.AddDbContext<Contexto>(x=>x.UseMySql(conexion,ServerVersion.AutoDetect(conexion)));


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
