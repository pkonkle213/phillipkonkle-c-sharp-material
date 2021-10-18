using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using WorldGeography.Models;

namespace WorldGeography.DAL
{
    public class LanguageSqlDAO : ILanguageDAO
    {
        private readonly string connectionString;

        private const string SqlSelectByCountry = 
            "SELECT countrycode, language, isofficial, percentage " +
            "FROM countrylanguage " +
            "WHERE countrycode = @countrycode";

        private const string SqlInsert = 
            "INSERT INTO countrylanguage (countrycode, language, isofficial, percentage) " +
            "VALUES (@countrycode, @language, @isofficial, @percentage);";

        private const string SqlDelete = 
            "DELETE FROM countrylanguage " +
            "WHERE countrycode = @countrycode AND language = @language;";

        private const string SqlNotGoingToUseThis = 
            "SELECT * FROM " +
            "countrylanguage " +
            "WHERE countrycode = @countrycode";

        /// <summary>
        /// Creates a sql based language dao.
        /// </summary>
        /// <param name="databaseConnectionString"></param>
        public LanguageSqlDAO(string databaseConnectionString)
        {
            this.connectionString = databaseConnectionString;
        }

        public IEnumerable<Language> GetLanguages(string countryCode)
        {
            List<Language> results = new List<Language>();

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    SqlCommand command = new SqlCommand(SqlSelectByCountry, conn);
                    command.Parameters.AddWithValue("@countrycode", countryCode);

                    SqlDataReader reader = command.ExecuteReader(); // Queries the database and gives us a reader


                    // Loop through each row in the results
                    while (reader.Read())
                    {
                        Language lang = new Language();

                        lang.CountryCode = Convert.ToString(reader["countrycode"]);
                        lang.Name = Convert.ToString(reader["language"]);
                        lang.IsOfficial = Convert.ToBoolean(reader["isofficial"]);
                        lang.Percentage = Convert.ToInt32(reader["percentage"]); // 0.7 -> ???

                        results.Add(lang);
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Problem querying database " + ex.Message);
            }

            return results;
        }

        public bool AddNewLanguage(Language newLanguage)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    SqlCommand command = new SqlCommand(SqlInsert, conn);
                    command.Parameters.AddWithValue("@countrycode", newLanguage.CountryCode);
                    command.Parameters.AddWithValue("@language", newLanguage.Name);
                    command.Parameters.AddWithValue("@isofficial", newLanguage.IsOfficial);
                    command.Parameters.AddWithValue("@percentage", newLanguage.Percentage);

                    command.ExecuteNonQuery();
                }

                return true;
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Could not add language: " + ex.Message);
                return false;
            }
        }

        public bool RemoveLanguage(Language deadLanguage)
        {
            try
            {
                // Create a connection to the database
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open(); // Establish the connection

                    /* SQL We're about to run:                      
                    "DELETE FROM countrylanguage " +
                    "WHERE countrycode = @countrycode AND language = @language;";

                    Gets transformed to...

                    DELETE FROM countrylanguage WHERE countrycode = 'USA' AND language = 'French';
                     */

                    // Build a command to run on the database
                    SqlCommand command = new SqlCommand(SqlDelete, conn);
                    command.Parameters.AddWithValue("@countrycode", deadLanguage.CountryCode);
                    command.Parameters.AddWithValue("@language", deadLanguage.Name);

                    // Execute the command on the database
                    command.ExecuteNonQuery();
                }

                return true;
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Could not work with database: " + ex.Message);
                return false;
            }
        }
    }
}
