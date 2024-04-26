using System.Reflection;
using Microsoft.EntityFrameworkCore;
using Tumin.Order.Domain.Entities;

namespace Tumin.Order.Persistence.Context;

public class OrderDbContext: DbContext
{
    DbSet<Address> Addresses { get; set; }
    DbSet<OrderDetail> OrderDetails { get; set; }
    DbSet<Ordering> Orderings { get; set; }
    
    public OrderDbContext(DbContextOptions<OrderDbContext> dbContextOptions) : base(dbContextOptions)
    {
        AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true); 
    }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder) =>
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
}