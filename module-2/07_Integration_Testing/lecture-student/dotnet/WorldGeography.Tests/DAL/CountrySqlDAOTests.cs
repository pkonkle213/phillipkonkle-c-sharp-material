using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using WorldGeography.DAL;
using WorldGeography.Models;
using WorldGeography.Tests.DAL;

namespace WorldGeography.Tests
{
    [TestClass]
    public class CountrySqlDAOTests : WorldDAOTestsBase
    {
        [TestMethod]
        public void GetCountriesTest_Should_ReturnAllCountries()
        {
            // Arrange

            // Act

            // Assert
            Assert.Inconclusive("Implement me!");
        }

        [TestMethod]
        [DataRow("North America", 1)]
        [DataRow("South America", 0)]
        [DataRow("Asia", 0)]
        public void GetCountriesByContinent_Should_ReturnCorrectNumberOfCountries(string continent, int expectedCount)
        {
            // Arrange

            // Act

            // Assert
            Assert.Inconclusive("Implement me!");
        }
    }
}
