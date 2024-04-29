using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Tumin.Cargo.DataAccessLayer.Concrete.DbConfig;

public class DesignTimeDbContextFactory:IDesignTimeDbContextFactory<CargoDbContext>
{
    public CargoDbContext CreateDbContext(string[] args)
    {
        var dbContextOptionsBuilder = new DbContextOptionsBuilder<CargoDbContext>();
        dbContextOptionsBuilder.UseNpgsql(Configuration.ConnectionString).EnableSensitiveDataLogging();
        return new CargoDbContext(dbContextOptionsBuilder.Options);
    }
}