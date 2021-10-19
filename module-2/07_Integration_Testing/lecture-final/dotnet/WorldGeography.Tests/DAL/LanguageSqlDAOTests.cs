using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using WorldGeography.DAL;
using WorldGeography.Models;
using WorldGeography.Tests.DAL;

namespace WorldGeography.Tests
{
    [TestClass]
    public class LanguageSqlDAOTests : WorldDAOTestsBase
    {
        [TestMethod]
        [DataRow("USA", 1)]
        [DataRow("XYZ", 0)]
        public void GetLanguagesTest(string countryCode, int expectedCount)
        {
            // Arrange
            LanguageSqlDAO dao = new LanguageSqlDAO(ConnectionString);

            // Act
            IEnumerable<Language> languages = dao.GetLanguages(countryCode);

            // Assert
            Assert.IsNotNull(languages);
            Assert.AreEqual(expectedCount, languages.Count());
        }

        [TestMethod]
        public void AddLanguage()
        {
            // Arrange
            LanguageSqlDAO dao = new LanguageSqlDAO(ConnectionString);
            Language language = new Language
            {
                CountryCode = "USA",
                IsOfficial = false,
                Name = "SQL",
                Percentage = 100
            };

            // Act
            bool result = dao.AddNewLanguage(language);

            // Assert
            Assert.IsTrue(result);
            Assert.AreEqual(2, GetRowCount("countrylanguage"));
        }

        [TestMethod]
        [ExpectedException(typeof(SqlException))]
        public void AddLanguage_FailsBecauseLanguageExists()
        {
            // Arrange
            LanguageSqlDAO dao = new LanguageSqlDAO(ConnectionString);
            Language language = new Language
            {
                CountryCode = "USA",
                IsOfficial = true,
                Name = "C#",
                Percentage = 100
            };

            // Act
            dao.AddNewLanguage(language); // This should throw an exception

            // Assert
            Assert.Fail("Expected a SQL Exception to be thrown before this line was reached");
        }

        [TestMethod]
        public void RemoveLanguage()
        {
            // Arrange
            LanguageSqlDAO dao = new LanguageSqlDAO(ConnectionString);
            Language language = new Language();
            language.CountryCode = "USA";
            language.Name = "C#";

            // Act
            bool result = dao.RemoveLanguage(language);

            // Assert
            Assert.IsTrue(result);
            Assert.AreEqual(0, GetRowCount("countrylanguage"));
        }
    }
}
