using Microsoft.Extensions.Configuration;
using System.IO;
using WorldGeography.DAL;

namespace WorldGeography
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Get Settings from AppSettings.json
            IConfigurationBuilder builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
            
            // Load the connection string from the appsettings.json file
            IConfigurationRoot configuration = builder.Build();
            string connectionString = configuration.GetConnectionString("World");

            // Create our data access objects
            ICityDAO cityDAO = null;
            ICountryDAO countryDAO = null;
            ILanguageDAO languageDAO = null;

            // Run the Application
            WorldGeographyCLI cli = new WorldGeographyCLI(cityDAO, countryDAO, languageDAO);
            cli.RunCLI();
        }
    }
}
