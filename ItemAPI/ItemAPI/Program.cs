using ItemAPI.Models;
using Microsoft.EntityFrameworkCore;
using Item.Application;
using Item.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//builder.Services.AddDbContext<ItemContext>(options =>
//    options.UseSqlServer(builder.Configuration.GetConnectionString("DevConnection"))
//);

var connectionString = builder.Configuration.GetConnectionString("DevConnection");
builder.Services.AddItemApplicationMediatR();
builder.Services.AddPersistence(connectionString);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors(option =>
    option.WithOrigins("http://localhost:4200")
    .AllowAnyMethod()
    .AllowAnyHeader()
);

app.UseAuthorization();

app.MapControllers();

app.Run();
