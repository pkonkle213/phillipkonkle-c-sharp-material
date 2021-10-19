using System;
using System.Collections.Generic;
using System.Text;
using WorldGeography.Models;

namespace WorldGeography.DAL
{
    public class FakeCountryDao : ICountryDAO
    {
        public IEnumerable<Country> GetCountries()
        {
            List<Country> countries = new List<Country>();

            Country country = new Country();
            country.Name = "Canda";
            country.Continent = "North America";

            countries.Add(country);

            return countries;
        }

        public IEnumerable<Country> GetCountries(string continent)
        {
            List<Country> countries = new List<Country>();

            if (continent == "North America")
            {
                Country country = new Country();
                country.Name = "Canda";
                country.Continent = "North America";

                countries.Add(country);
            }

            return countries;
        }
    }
}
