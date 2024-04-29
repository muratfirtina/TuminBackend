

using Microsoft.Extensions.Configuration;

namespace Tumin.Cargo.DataAccessLayer.Concrete.DbConfig;

public class Configuration
{
    public static string ConnectionString
    {
        get
        {
            ConfigurationManager configurationManager = new();
            configurationManager.SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../../Cargo/Tumin.Cargo.WebApi"));
            configurationManager.AddJsonFile("appsettings.json");
            return configurationManager.GetConnectionString("PostgreSQL");
            
        }
        
    }
}