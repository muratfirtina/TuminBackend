using System.Reflection;
using Microsoft.EntityFrameworkCore;
using Tumin.Cargo.EntityLayer.Concrete;

namespace Tumin.Cargo.DataAccessLayer.Concrete;

public class CargoDbContext:DbContext
{
    public DbSet<CargoCompany>? CargoCompanies { get; set; }
    public DbSet<CargoDetail>? CargoDetails { get; set; }
    public DbSet<CargoCustomer>? CargoCustomers { get; set; }
    public DbSet<CargoOperation>? CargoOperations { get; set; }
    public CargoDbContext(DbContextOptions<CargoDbContext> dbContextOptions) : base(dbContextOptions)
    {
        AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true); 
    }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder) =>
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
}