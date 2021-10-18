using Microsoft.Extensions.Configuration;
using System.IO;
using WorldGeography.DAL;

namespace WorldGeography
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Grab a connection string from appsettings.json
            IConfigurationRoot configuration = LoadAppConfiguration();
            string connectionString = configuration.GetConnectionString("World");

            // Create our data access objects (We'll do this in lecture together)
            ICityDAO cityDAO = new CitySqlDAO(connectionString);
            ICountryDAO countryDAO = new CountrySqlDAO(connectionString);
            ILanguageDAO languageDAO = new LanguageSqlDAO(connectionString);

            // Run the Application
            WorldGeographyCLI cli = new WorldGeographyCLI(cityDAO, countryDAO, languageDAO);
            cli.Run();
        }

        // NOTE: You really don't need to worry at all about anything in this method
        private static IConfigurationRoot LoadAppConfiguration()
        {
            // Get Settings from AppSettings.json
            ConfigurationBuilder builder = new ConfigurationBuilder();
            builder.SetBasePath(Directory.GetCurrentDirectory());
            builder.AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

            // Generate an IConfigurationRoot instance that other parts of the app can use
            return builder.Build();
        }
    }
}
