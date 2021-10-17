using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using WorldGeography.Models;

namespace WorldGeography.DAL
{
    public class LanguageSqlDAO : ILanguageDAO
    {
        private readonly string connectionString;

        private const string SqlSelectByCountry = "SELECT countrycode, language, isofficial, percentage FROM countrylanguage WHERE countrycode = @countrycode";
        private const string SqlInsert = "INSERT INTO countrylanguage (countrycode, language, isofficial, percentage) VALUES (@countrycode, @language, @isofficial, @percentage);";
        private const string SqlDelete = "DELETE FROM countrylanguage WHERE countrycode = @countrycode AND language = @language;";

        /// <summary>
        /// Creates a sql based language dao.
        /// </summary>
        /// <param name="databaseConnectionString"></param>
        public LanguageSqlDAO(string databaseConnectionString)
        {
            connectionString = databaseConnectionString;
        }

        public IEnumerable<Language> GetLanguages(string countryCode)
        {
            throw new NotImplementedException();
        }

        public bool AddNewLanguage(Language newLanguage)
        {
            throw new NotImplementedException();
        }

        public bool RemoveLanguage(Language deadLanguage)
        {
            throw new NotImplementedException();
        }
    }
}
