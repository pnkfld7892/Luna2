using Microsoft.Extensions.Configuration;
using System.IO;

namespace Luna2.DataAccess.AppConfig
{
    public class AppConfiguation
    {
        public readonly string _connectionString = string.Empty;
        public AppConfiguation()
        {
            var configurationBuilder = new ConfigurationBuilder();
            var path = Path.Combine(Directory.GetCurrentDirectory(), "appsettings.json");

            configurationBuilder.AddJsonFile(path, false);

            var root = configurationBuilder.Build();
            _connectionString = root.GetSection("ConnectionStrings").GetSection("LunaData").Value;
        }
        
        public string ConnectionString
        {
            get => _connectionString;
        }
    }
}
