using System.Data;
using System.Reflection;
using Microsoft.EntityFrameworkCore;
using Npgsql;
using Tumin.Discount.Entites;

namespace Tumin.Discount.Context;

public class DiscountDapperDbContext:DbContext
{
    public DbSet<Coupon>? Coupons { get; set; }
    public IDbConnection CreateConnection() => Database.GetDbConnection();
    

    public DiscountDapperDbContext(DbContextOptions<DiscountDapperDbContext> dbContextOptions) : base(dbContextOptions)
    {
        AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true); 
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}