using Microsoft.EntityFrameworkCore;
using Tumin.Order.Application;
using Tumin.Order.Application.Features.CQRS.Handlers.AddressHandlers;
using Tumin.Order.Application.Features.CQRS.Handlers.OrderDetailHandlers;
using Tumin.Order.Application.Interfaces;
using Tumin.Order.Persistence.Context;
using Tumin.Order.Persistence.Context.DbConfig;
using Tumin.Order.Persistence.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddApplicationServices();
builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));

builder.Services.AddDbContext<OrderDbContext>(options =>
{
    options.UseNpgsql(Configuration.ConnectionString);
});

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