using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using WorldGeography.Models;

namespace WorldGeography.DAL
{
    public class CountrySqlDAO : ICountryDAO
    {
        private readonly string connectionString;

        private const string SqlSelectAll = 
            "SELECT code, name, continent, region, surfacearea, population, governmentform " +
            "FROM country";

        private const string SqlSelectAllByContinent = 
            "SELECT code, name, continent, region, surfacearea, population, governmentform " +
            "FROM country " +
            "WHERE continent = @continent";

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
            List<Country> results = new List<Country>();

            try
            {
                using (SqlConnection conn = new SqlConnection(this.connectionString))
                {
                    conn.Open();

                    SqlCommand command = new SqlCommand(SqlSelectAll, conn);

                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        Country country = BuildCountryFromDataReader(reader);

                        results.Add(country);
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Could not query the database " + ex.Message);
            }

            return results;
        }

        public IEnumerable<Country> GetCountries(string continent)
        {
            List<Country> results = new List<Country>();

            try
            {
                using (SqlConnection conn = new SqlConnection(this.connectionString))
                {
                    conn.Open();

                    SqlCommand command = new SqlCommand(SqlSelectAllByContinent, conn);
                    command.Parameters.AddWithValue("@continent", continent);

                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        Country country = BuildCountryFromDataReader(reader);

                        results.Add(country);
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Could not query the database " + ex.Message);
            }

            return results;
        }

        private Country BuildCountryFromDataReader(SqlDataReader reader)
        {
            return new Country
            {
                Code = Convert.ToString(reader["code"]),
                Name = Convert.ToString(reader["name"]),
                Continent = Convert.ToString(reader["continent"]),
                Region = Convert.ToString(reader["region"]),
                SurfaceArea = Convert.ToDouble(reader["surfacearea"]),
                Population = Convert.ToInt32(reader["population"]),
                GovernmentForm = Convert.ToString(reader["governmentform"])
            };
        }
    }
}
