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
    public class CitySqlDAOTests : WorldDAOTestsBase
    {
        [TestMethod]
        [DataRow("USA", 1)]
        [DataRow("FRA", 0)]
        public void GetCitiesByCountryCode_Should_ReturnRightNumberOfCities(string countryCode, int expectedCityCount)
        {
            // Arrange
            CitySqlDAO dao = new CitySqlDAO(ConnectionString);

            // Act
            IEnumerable<City> results = dao.GetCitiesByCountryCode(countryCode);

            // Assert
            Assert.IsNotNull(results);
            Assert.AreEqual(expectedCityCount, results.Count());
        }

        [TestMethod]
        public void AddCity_Should_IncreaseCountBy1()
        {
            // Arrange
            CitySqlDAO dao = new CitySqlDAO(ConnectionString);
            City city = new City();
            city.CountryCode = "USA"; // FK to Country
            city.Name = "Arch City";
            city.District = "Ohio";
            city.Population = 21;

            // Act
            int id = dao.AddCity(city);

            // Assert
            Assert.IsTrue(id > 1, "Added city ID looks to be invalid");
            Assert.AreEqual(2, GetRowCount("city"));
        }

        [TestMethod]
        [ExpectedException(typeof(SqlException))]
        public void AddCity_Should_Fail_IfCountryDoesNotExist()
        {
            // Arrange
            CitySqlDAO dao = new CitySqlDAO(ConnectionString);
            City city = new City();
            city.CountryCode = "NIL"; // FK to Country
            city.Name = "Null City";
            city.District = "Ohio";
            city.Population = 21;

            // Act
            dao.AddCity(city);

            // Assert
            Assert.Fail("Expected a SQL Exception to be thrown before this line was reached");
        }
    }
}
