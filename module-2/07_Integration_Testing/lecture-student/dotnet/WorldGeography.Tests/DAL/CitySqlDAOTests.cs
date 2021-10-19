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
            IEnumerable<City> result = dao.GetCitiesByCountryCode(countryCode);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(expectedCityCount, result.Count());
        }

        [TestMethod]
        public void AddCity_Should_IncreaseCountBy1()
        {
            // Arrange
            CitySqlDAO dao = new CitySqlDAO(this.ConnectionString);
            City city = new City();
            city.CountryCode = "USA";
            city.District = "Wyoming";
            city.Name = "YoMama";
            city.Population = 1000000;

            // Act
            int id = dao.AddCity(city); //AddCity returns the index of the newly created city
            
            // Assert
            Assert.IsTrue(id > 1, "Added city ID looks to be invalid");
            Assert.AreEqual(2, GetRowCount("city"));
        }

        [TestMethod]
        [ExpectedException(typeof(SqlException))] //This is what makes the test pass
        public void AddCity_Should_Fail_IfCountryDoesNotExist()
        {
            // Arrange
            CitySqlDAO dao = new CitySqlDAO(this.ConnectionString);
            City city = new City();
            city.CountryCode = "FUX";
            city.District = "Maine";
            city.Name = "Phillip";
            city.Population = 1000;

            // Act
            dao.AddCity(city);

            // Assert
            Assert.Fail("Expected a SQL Exception to be thrown before this line was reached");
        }
    }
}
