using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using WorldGeography.Models;

namespace WorldGeography.DAL
{
    public class CitySqlDAO : ICityDAO
    {
        private readonly string connectionString;

        private const string SqlInsert = 
            "INSERT INTO city (name, countrycode, district, population) " +
            "VALUES (@name, @countrycode, @district, @population);";

        private const string SqlSelect = 
            "SELECT id, name, countrycode, district, population " +
            "FROM city " +
            "WHERE countryCode = @countryCode;";

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
            List<City> results = new List<City>();

            try
            {
                using (SqlConnection conn = new SqlConnection(this.connectionString))
                {
                    conn.Open();

                    SqlCommand command = new SqlCommand(SqlSelect, conn);
                    command.Parameters.AddWithValue("@countryCode", countryCode);

                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        City city = new City();
                        city.CityId = Convert.ToInt32(reader["id"]);
                        city.Name = Convert.ToString(reader["name"]);
                        city.CountryCode = Convert.ToString(reader["countryCode"]);
                        
                        // We only want to set the population if it isn't null in the data set
                        if (reader["population"] != DBNull.Value)
                        {
                            city.Population = Convert.ToInt32(reader["population"]);
                        }
                    results.Add(city);
                    }

                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Could not query database " + ex.Message);
            }

            return results;
        }
    }
}
