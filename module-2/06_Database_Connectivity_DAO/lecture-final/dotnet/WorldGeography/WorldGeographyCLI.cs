using System;
using System.Collections.Generic;
using System.Linq;
using WorldGeography.DAL;
using WorldGeography.Models;

namespace WorldGeography
{
    public class WorldGeographyCLI
    {
        private readonly ICityDAO cityDAO;
        private readonly ICountryDAO countryDAO;
        private readonly ILanguageDAO languageDAO;

        public WorldGeographyCLI(ICityDAO cityDAO, ICountryDAO countryDAO, ILanguageDAO languageDAO)
        {
            // Validate parameters
            if (cityDAO == null) 
            {
                throw new ArgumentNullException("cityDAO"); 
            }
            if (countryDAO == null) throw new ArgumentNullException("countryDAO");
            if (languageDAO == null) throw new ArgumentNullException("languageDAO");

            // Set fields
            this.cityDAO = cityDAO;
            this.languageDAO = languageDAO;
            this.countryDAO = countryDAO;
        }

        public void Run()
        {
            PrintHeader();
            PrintMenu();

            while (true)
            {
                string command = Console.ReadLine();

                Console.Clear();

                switch (command.ToLower())
                {
                    case "1": // Get all countries
                        GetCountries();
                        break;

                    case "2": // Get all countries in North America
                        GetCountriesInNorthAmerica();
                        break;

                    case "3": // Get all cities by their country code
                        GetCitiesByCountryCode();
                        break;

                    case "4": // Get all languages for a given country
                        GetLanguagesForCountry();
                        break;

                    case "5": // Add a new language
                        AddNewLanguage();
                        break;

                    case "6": // Remove an existing language
                        RemoveLanguage();
                        break;

                    case "7": // Add a new city
                        AddCity();
                        break;

                    case "q": // Quit the application
                        Console.WriteLine("Thank you for using the world geography cli app");
                        return;

                    default: // Something else
                        Console.WriteLine("The command provided was not a valid command, please try again.");
                        break;
                }

                PrintMenu();
            }
        }

        private void PrintHeader()
        {
            Console.WriteLine(@" _    _  _____ ______  _     ______     ______   ___   _____   ___  ______   ___   _____  _____ ");
            Console.WriteLine(@"| |  | ||  _  || ___ \| |    |  _  \    |  _  \ / _ \ |_   _| / _ \ | ___ \ / _ \ /  ___||  ___|");
            Console.WriteLine(@"| |  | || | | || |_/ /| |    | | | |    | | | |/ /_\ \  | |  / /_\ \| |_/ // /_\ \\ `--. | |__  ");
            Console.WriteLine(@"| |/\| || | | ||    / | |    | | | |    | | | ||  _  |  | |  |  _  || ___ \|  _  | `--. \|  __| ");
            Console.WriteLine(@"\  /\  /\ \_/ /| |\ \ | |____| |/ /     | |/ / | | | |  | |  | | | || |_/ /| | | |/\__/ /| |___ ");
            Console.WriteLine(@" \/  \/  \___/ \_| \_|\_____/|___/      |___/  \_| |_/  \_/  \_| |_/\____/ \_| |_/\____/ \____/ ");
        }

        private void PrintMenu()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Main-Menu Type in a command");
            Console.WriteLine(" 1 - Get all of the countries");
            Console.WriteLine(" 2 - Get a list of the countries in North America");
            Console.WriteLine(" 3 - Get a list of the cities by country code");
            Console.WriteLine(" 4 - Get a list of the languages by country code");
            Console.WriteLine(" 5 - Add a new language");
            Console.WriteLine(" 6 - Remove language");
            Console.WriteLine(" 7 - Add a city");
            Console.WriteLine(" Q - Quit");
        }

        private void AddCity()
        {
            string name = CLIHelper.GetString("Name of the city:");
            string code = CLIHelper.GetString("Country code:");
            string district = CLIHelper.GetString($"District {name} is in:");
            int population = CLIHelper.GetInteger($"Population of {name}:");

            City city = new City()
            {
                CountryCode = code,
                Name = name,
                District = district,
                Population = population
            };

            City city2 = new City(); // This is identical to what city is doing above
            city2.CountryCode = code;
            city2.Name = name;
            city2.District = district;
            city2.Population = population;

            int id = cityDAO.AddCity(city);

            if (id >= 0)
            {
                Console.WriteLine("City added with ID " + id);
            } 
            else
            {
                Console.WriteLine("Could not add city");
            }
        }

        private void GetCountries()
        {
            IEnumerable<Country> countries = countryDAO.GetCountries(); // IEnumerable is either a list or array - something we can loop over

            Console.WriteLine();
            Console.WriteLine("Printing all of the countries");

            int index = 1;
            foreach (Country country in countries)
            {
                Console.WriteLine($"{index++} - {country}");
            }
        }

        private void GetCountriesInNorthAmerica()
        {
            string continent = CLIHelper.GetString("Continent to filter by:");

            var northAmericanCountries = countryDAO.GetCountries(continent);

            Console.WriteLine();
            Console.WriteLine("All North American Countries");

            foreach (var country in northAmericanCountries)
            {
                Console.WriteLine(country);
            }
        }

        private void GetCitiesByCountryCode()
        {
            string countryCode = CLIHelper.GetString("Enter the country code that you want to retrieve:");

            IEnumerable<City> cities = cityDAO.GetCitiesByCountryCode(countryCode);

            Console.WriteLine();
            Console.WriteLine($"Printing {cities.Count()} cities for {countryCode}");

            foreach (var city in cities)
            {
                Console.WriteLine(city);
            }
        }

        private void AddNewLanguage()
        {
            string countryCode = CLIHelper.GetString("Enter the country code the language is for:");
            bool officialOnly = CLIHelper.GetBool("Is it official only? True/False ");
            int percentage = CLIHelper.GetInteger("What percentage is it spoken by?");
            string name = CLIHelper.GetString("What is the name of the lanaguage?");

            Language lang = new Language
            {
                CountryCode = countryCode,
                IsOfficial = officialOnly,
                Percentage = percentage,
                Name = name
            };

            bool result = languageDAO.AddNewLanguage(lang);

            if (result)
            {
                Console.WriteLine("Success!");
            }
            else
            {
                Console.WriteLine("The new language was not inserted");
            }
        }

        private void RemoveLanguage()
        {
            string language = CLIHelper.GetString("Which language should be removed:");
            string countryCode = CLIHelper.GetString("For which country code:");

            Language lang = new Language
            {
                CountryCode = countryCode,
                Name = language
            };

            bool result = languageDAO.RemoveLanguage(lang);

            if (result)
            {
                Console.WriteLine("Success!");
            }
            else
            {
                Console.WriteLine("The language was not found or removed.");
            }
        }

        private void GetLanguagesForCountry()
        {
            string countryCode = CLIHelper.GetString("Enter the country code you want to retrieve:");

            IEnumerable<Language> languages = languageDAO.GetLanguages(countryCode);

            Console.WriteLine();
            Console.WriteLine($"Printing {languages.Count()} languages for {countryCode}");

            foreach (Language language in languages)
            {
                Console.WriteLine(language);
            }
        }
    }
}
