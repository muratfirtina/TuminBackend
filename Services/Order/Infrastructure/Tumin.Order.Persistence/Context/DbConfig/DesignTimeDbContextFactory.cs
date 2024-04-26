using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Tumin.Order.Persistence.Context.DbConfig;

public class DesignTimeDbContextFactory:IDesignTimeDbContextFactory<OrderDbContext>
{
    public OrderDbContext CreateDbContext(string[] args)
    {
        var dbContextOptionsBuilder = new DbContextOptionsBuilder<OrderDbContext>();
        dbContextOptionsBuilder.UseNpgsql(Configuration.ConnectionString).EnableSensitiveDataLogging();
        return new OrderDbContext(dbContextOptionsBuilder.Options);
    }
}