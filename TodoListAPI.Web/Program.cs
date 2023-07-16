using Microsoft.EntityFrameworkCore;
using TodoListAPI.Domain.Interfaces;
using TodoListAPI.Infrastructure.Data;
using TodoListAPI.Infrastructure.Repositories;
using TodoListAPI.Application;

var builder = WebApplication.CreateBuilder(args);

var connectionString = builder.Configuration.GetConnectionString("Default");
builder.Services.AddDbContext<AppDbContext>(o => o.UseSqlServer(connectionString));
// Add services to the container.

builder.Services.AddScoped<ITodoListRepository, TodoListRepository>();
builder.Services.AddScoped<IItemTagRepository, ItemTagRepository>();

builder.Services.AddApplicationServices();

builder.Services.AddControllers();
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
