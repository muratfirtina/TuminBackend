using System.IO;
using Microsoft.Extensions.Configuration;

namespace Tumin.Discount.Context.DbConfig;

public class Configuration
{
    static public string ConnectionString
    {
        get
        {
            ConfigurationManager configurationManager = new();
            configurationManager.SetBasePath(Directory.GetCurrentDirectory());
            configurationManager.AddJsonFile("appsettings.json");
            return configurationManager.GetConnectionString("PostgreSQL");
            
        }
        
    }
}