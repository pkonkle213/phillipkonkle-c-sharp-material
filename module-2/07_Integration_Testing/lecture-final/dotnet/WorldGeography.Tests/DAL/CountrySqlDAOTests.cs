using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using WorldGeography.DAL;
using WorldGeography.Models;
using WorldGeography.Tests.DAL;

namespace WorldGeography.Tests
{
    [TestClass]
    public class CountrySqlDAOTests : WorldDAOTestsBase
    {
        // IEnumerable<T> - I can loop over it!
        // ICollection<T> - I can add things to it!
        // IList<T>       - I can get things out by index

        [TestMethod]
        public void GetCountriesTest_Should_ReturnAllCountries()
        {
            // Arrange
            CountrySqlDAO dao = new CountrySqlDAO(this.ConnectionString);

            // Act
            IEnumerable<Country> result = dao.GetCountries();

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.Count());
        }

        [TestMethod]
        [DataRow("North America", 1)]
        [DataRow("South America", 0)]
        [DataRow("Asiago", 0)]
        public void GetCountriesByContinent_Should_ReturnCorrectNumberOfCountries(string continent, int expectedCount)
        {
            // Arrange
            CountrySqlDAO dao = new CountrySqlDAO(ConnectionString);

            // Act
            IEnumerable<Country> result = dao.GetCountries(continent);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(expectedCount, result.Count());
        }
    }
}
