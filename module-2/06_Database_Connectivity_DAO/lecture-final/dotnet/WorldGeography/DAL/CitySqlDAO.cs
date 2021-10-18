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
            "VALUES (@name, @countrycode, @district, @population); " +
            "SELECT @@IDENTITY;"; // Select the ID of the row we just added

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

        public int AddCity(City city)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(this.connectionString))
                {
                    conn.Open(); // TODO: Talk about what happens if we don't do this, or the connection string is bad

                    SqlCommand command = new SqlCommand(SqlInsert, conn);
                    command.Parameters.AddWithValue("@name", city.Name);
                    command.Parameters.AddWithValue("@countrycode", city.CountryCode);
                    command.Parameters.AddWithValue("@district", city.District);
                    command.Parameters.AddWithValue("@population", city.Population);

                    int id = Convert.ToInt32(command.ExecuteScalar()); // Gets the first cell of the results. This is @@IDENTITY

                    return id;
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Could not add city: " + ex.Message);
                return -1; // No city
            }
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
                        city.CountryCode = Convert.ToString(reader["countrycode"]);
                        city.District = Convert.ToString(reader["district"]);

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
