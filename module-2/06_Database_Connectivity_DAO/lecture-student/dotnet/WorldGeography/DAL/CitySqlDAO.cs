using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using WorldGeography.Models;

namespace WorldGeography.DAL
{
    public class CitySqlDAO : ICityDAO
    {
        private readonly string connectionString;

        private const string SqlInsert = "INSERT INTO city (name, countrycode, district, population) VALUES (@name, @countrycode, @district, @population);";
        private const string SqlSelect = "SELECT id, name, countrycode, district, population FROM city WHERE countryCode = @countryCode;";

        /// <summary>
        /// Creates a new sql-based city dao.
        /// </summary>
        /// <param name="databaseconnectionString"></param>
        public CitySqlDAO(string databaseconnectionString)
        {
            connectionString = databaseconnectionString;
        }

        public void AddCity(City city)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<City> GetCitiesByCountryCode(string countryCode)
        {
            throw new NotImplementedException();
        }
    }
}
