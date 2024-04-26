using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Tumin.Discount.Context.DbConfig;

public class DesignTimeDbContextFactory: IDesignTimeDbContextFactory<DiscountDapperDbContext>
{
    public DiscountDapperDbContext CreateDbContext(string[] args)
    {
        var dbContextOptionsBuilder = new DbContextOptionsBuilder<DiscountDapperDbContext>();
        dbContextOptionsBuilder.UseNpgsql(Configuration.ConnectionString).EnableSensitiveDataLogging();
        return new DiscountDapperDbContext(dbContextOptionsBuilder.Options);
    }
}