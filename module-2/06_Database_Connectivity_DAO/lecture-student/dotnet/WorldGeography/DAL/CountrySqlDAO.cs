using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using WorldGeography.Models;

namespace WorldGeography.DAL
{
    public class CountrySqlDAO : ICountryDAO
    {
        private readonly string connectionString;

        private const string SqlSelectAll = "SELECT code, name, continent, region, surfacearea, population, governmentform FROM country";
        private const string SqlSelectAllByContinent = "SELECT code, name, continent, region, surfacearea, population, governmentform FROM country WHERE continent = @continent";

        /// <summary>
        /// Creates a sql based country dao.
        /// </summary>
        /// <param name="databaseconnectionString"></param>
        public CountrySqlDAO(string databaseconnectionString)
        {
            connectionString = databaseconnectionString;
        }

        public IEnumerable<Country> GetCountries()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Country> GetCountries(string continent)
        {
            throw new NotImplementedException();
        }
    }
}
