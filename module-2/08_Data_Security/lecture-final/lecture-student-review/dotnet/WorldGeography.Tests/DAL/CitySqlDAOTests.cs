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
            CitySqlDAO dao = new CitySqlDAO(this.ConnectionString);

            // Act
            IList<City> cities = dao.GetCitiesByCountryCode(countryCode);

            // Assert
            Assert.AreEqual(expectedCityCount, cities.Count);
        }

        [TestMethod]
        public void AddCity_Should_IncreaseCountBy1()
        {
            // Arrange
            CitySqlDAO dao = new CitySqlDAO(this.ConnectionString);
            City testCity = new City();
            testCity.Name = "Doesn't Matter";
            testCity.CountryCode = "USA";
            testCity.District = "Doesn't Matter";
            testCity.Population = 1;

            int oldRowCount = this.GetRowCount("city");

            // Act
            int newCityId = dao.AddCity(testCity);

            // Assert
            Assert.IsTrue(newCityId > 0);

            Assert.AreEqual(oldRowCount + 1, this.GetRowCount("city"));
        }

        [TestMethod]
        [ExpectedException(typeof(SqlException))]
        public void AddCity_Should_Fail_IfCountryDoesNotExist()
        {
            // Arrange
            CitySqlDAO dao = new CitySqlDAO(ConnectionString);
            City testCity = new City();
            testCity.Name = "Doesn't Matter";
            testCity.CountryCode = "NIL"; // Country doesn't exist
            testCity.District = "Doesn't Matter";
            testCity.Population = 1;

            // Act
            dao.AddCity(testCity); // This line should throw SqlException

            // Assert
            Assert.Fail("Expected a SQL Exception to be thrown before this line was reached");
        }
    }
}
