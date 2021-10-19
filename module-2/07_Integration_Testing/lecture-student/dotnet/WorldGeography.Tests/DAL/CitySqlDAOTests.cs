using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Data.SqlClient;
using WorldGeography.DAL;
using WorldGeography.Models;
using WorldGeography.Tests.DAL;

namespace WorldGeography.Tests
{
    [TestClass]
    public class CitySqlDAOTests : WorldDAOTestsBase
    {
        [TestMethod]
        [DataRow("USA", 1)]
        [DataRow("FRA", 0)]
        public void GetCitiesByCountryCode_Should_ReturnRightNumberOfCities(string countryCode, int expectedCityCount)
        {
            // Arrange

            // Act

            // Assert
            Assert.Inconclusive("Implement me!");
        }

        [TestMethod]
        public void AddCity_Should_IncreaseCountBy1()
        {
            // Arrange

            // Act

            // Assert
            Assert.Inconclusive("Implement me!");
        }

        [TestMethod]
        [ExpectedException(typeof(SqlException))]
        public void AddCity_Should_Fail_IfCountryDoesNotExist()
        {
            // Arrange

            // Act

            // Assert
            Assert.Fail("Expected a SQL Exception to be thrown before this line was reached");
        }
    }
}
