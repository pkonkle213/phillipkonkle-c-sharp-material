using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Assessment.Tests
{
    [TestClass]
    public class HotelReservationTestsWithDataRow
    {
        [TestMethod]
        [DataRow(false, false, "59.99")] // Compiler doesn't allow a decimal literal here
        [DataRow(false, true, "72.98")] 
        public void CalcuateTotalIsAccurate(bool requiresCleaning, bool usedMinibar, string expectedStr)
        {
            // Arrange
            HotelReservation reservation = new HotelReservation("Test", 1);
            decimal expected = decimal.Parse(expectedStr); // Convert our string parameter to a decimal. MS didn't ask me.

            // Act
            decimal result = reservation.CalcuateTotal(requiresCleaning, usedMinibar);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        [DataRow(1, "59.99")] // Compiler doesn't allow a decimal literal here
        [DataRow(2, "119.98")] // Compiler doesn't allow a decimal literal here
        public void EstimatedTotalShouldBeAccurate(int numNights, string expectedStr)
        {
            // Arrange
            HotelReservation reservation = new HotelReservation("Test", numNights);
            decimal expected = decimal.Parse(expectedStr); // Convert our string parameter to a decimal. MS didn't ask me.

            // Act
            decimal total = reservation.EstimatedTotal;

            // Assert
            Assert.AreEqual(expected, total);
        }
    }
}
