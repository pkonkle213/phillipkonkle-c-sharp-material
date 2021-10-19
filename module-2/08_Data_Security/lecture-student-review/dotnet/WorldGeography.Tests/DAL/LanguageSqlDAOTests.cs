using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Data.SqlClient;
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
        public void GetLanguageCountShouldMatchExpected(string countryCode, int expectedCount)
        {
            // Arrange
            LanguageSqlDAO dao = new LanguageSqlDAO(ConnectionString);

            // Act
            IList<Language> languages = dao.GetLanguages(countryCode);

            // Assert
            Assert.AreEqual(expectedCount, languages.Count);
        }

        [TestMethod]
        public void AddLanguageShouldSucceed()
        {
            // Arrange
            LanguageSqlDAO dao = new LanguageSqlDAO(ConnectionString);
            Language testLanguage = new Language();
            testLanguage.Name = "Profanity";
            testLanguage.CountryCode = "USA";
            testLanguage.Percentage = 35;

            // Act
            bool success = dao.AddNewLanguage(testLanguage);

            // Assert
            Assert.IsTrue(success);
        }

        [TestMethod]
        [ExpectedException(typeof(SqlException))]
        public void AddLanguage_FailsBecauseLanguageExists()
        {
            // Arrange
            LanguageSqlDAO dao = new LanguageSqlDAO(ConnectionString);
            Language testLanguage = new Language();
            testLanguage.Name = "C#";
            testLanguage.CountryCode = "USA";
            testLanguage.Percentage = 35;

            // Act
            dao.AddNewLanguage(testLanguage); // This should fail since it already exists in the test data

            // Assert
            Assert.Fail("Expected a SQL Exception to be thrown before this line was reached");
        }

        [TestMethod]
        public void RemoveLanguageShouldSucceedIfLanguageExists()
        {
            // Arrange
            LanguageSqlDAO dao = new LanguageSqlDAO(ConnectionString);
            Language testLanguage = new Language();
            testLanguage.Name = "C#";
            testLanguage.CountryCode = "USA";
            testLanguage.Percentage = 35;

            // Act
            bool success = dao.RemoveLanguage(testLanguage);

            // Assert
            Assert.IsTrue(success);
        }
    }
}
