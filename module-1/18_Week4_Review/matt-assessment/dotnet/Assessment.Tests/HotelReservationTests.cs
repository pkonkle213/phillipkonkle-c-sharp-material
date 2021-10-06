using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Assessment.Tests
{
    [TestClass]
    public class HotelReservationTests
    {
        [TestMethod]
        public void CalcuateTotalWithoutCleaningOrMinibarIsAccurate()
        {
            // Arrange
            HotelReservation reservation = new HotelReservation("Test", 1);

            // Act
            decimal result = reservation.CalcuateTotal(false, false);

            // Assert
            Assert.AreEqual(59.99M, result);
        }

        [TestMethod]
        public void CalcuateTotalWithMinibarIsAccurate()
        {
            // Arrange
            HotelReservation reservation = new HotelReservation("Test", 1);

            // Act
            decimal result = reservation.CalcuateTotal(false, true);

            // Assert
            Assert.AreEqual(72.98M, result);
        }

        [TestMethod]
        public void EstimatedTotalForOneNightShouldBeAccurate()
        {
            // Arrange
            HotelReservation reservation = new HotelReservation("Test", 1);

            // Act
            decimal total = reservation.EstimatedTotal;

            // Assert
            Assert.AreEqual(59.99M, total);
        }
    }
}
