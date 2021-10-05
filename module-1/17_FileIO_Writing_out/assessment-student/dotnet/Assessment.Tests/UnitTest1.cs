using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Assessment.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [DataRow(true, true, 382.92)]
        [DataRow(true, false, 334.94)]
        [DataRow(false, true, 312.94)]
        [DataRow(false, false, 299.95)]

        public void HotelReservationShouldGiveTheCorrectActualTotal(bool input1, bool input2, double expected)
        {
            // There should be a test class to test the new class.
            // the UnitTest1 class can server as a template for what's inside of
            // the test class

            //Arrange
            HotelReservation hotel = new HotelReservation("Phillip",5);

            //Act
            double hopefully = (double)hotel.ActualTotal(input1, input2);

            //Assert
            Assert.AreEqual(expected, hopefully);
        }

        [TestMethod]
        [DataRow("Phillip",5,299.95)]
        [DataRow("Kevin",7,419.93)]
        [DataRow("Matt",1,59.99)]
        public void EstimatedPropertyShouldBeAccurate(string input1, int input2, double expected)
        {
            //Arrange
            HotelReservation newHotel = new HotelReservation(input1, input2);

            //Act
            //No actions needed after arrange as we're just testing a property

            //Assert
            Assert.AreEqual(expected, (double)newHotel.EstimatedTotal);
        }
    }
}
