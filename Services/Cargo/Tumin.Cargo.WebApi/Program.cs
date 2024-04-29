using System.Reflection;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using Tumin.Cargo.BusinessLayer;
using Tumin.Cargo.DataAccessLayer;
using Tumin.Cargo.DataAccessLayer.Concrete;
using Tumin.Cargo.DataAccessLayer.Concrete.DbConfig;
using Tumin.Cargo.DtoLayer;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddBussinesServices();
builder.Services.AddDataAccessServices();
builder.Services.AddDtoLayerServices();

builder.Services.AddDbContext<CargoDbContext>(options =>
{
    options.UseNpgsql(Configuration.ConnectionString);
});

builder.Services.AddAutoMapper(Assembly.GetExecutingAssembly());

builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(options =>
    {
        options.Authority = builder.Configuration["IdentityServerUrl"];
        options.RequireHttpsMetadata = false;
        options.Audience = "ResourceCargo";
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

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();