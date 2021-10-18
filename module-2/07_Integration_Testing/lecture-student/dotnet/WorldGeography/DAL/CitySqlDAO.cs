using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using WorldGeography.Models;

namespace WorldGeography.DAL
{
    public class CitySqlDAO : ICityDAO
    {
        private readonly string connectionString;

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
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand("INSERT INTO city VALUES (@name, @countrycode, @district, @population); SELECT @@IDENTITY;", conn);
                    cmd.Parameters.AddWithValue("@name", city.Name);
                    cmd.Parameters.AddWithValue("@countrycode", city.CountryCode);
                    cmd.Parameters.AddWithValue("@district", city.District);
                    cmd.Parameters.AddWithValue("@population", city.Population);

                    // Get the ID of the city that was added
                    int id = Convert.ToInt32(cmd.ExecuteScalar());

                    return id;
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Error saving city.");
                Console.WriteLine(ex.Message);

                throw;
            }
        }

        public IList<City> GetCitiesByCountryCode(string countryCode)
        {
            List<City> cities = new List<City>();

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                                                                                                                        // column    // param name
                    SqlCommand cmd = new SqlCommand("SELECT id, name, countrycode, district, population FROM city WHERE countryCode = @countryCode;", conn);
                                                // param name   // param value
                    cmd.Parameters.AddWithValue("@countryCode", countryCode);

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        City city = ConvertReaderToCity(reader);
                        cities.Add(city);
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("An error occurred reading cities by country.");
                Console.WriteLine(ex.Message);
            }

            return cities;
        }

        private City ConvertReaderToCity(SqlDataReader reader)
        {
            return new City
            {
                CityId = Convert.ToInt32(reader["id"]),
                Name = Convert.ToString(reader["name"]),
                CountryCode = Convert.ToString(reader["countrycode"]),
                District = Convert.ToString(reader["district"]),
                Population = Convert.ToInt32(reader["population"])
            };
        }
    }
}
