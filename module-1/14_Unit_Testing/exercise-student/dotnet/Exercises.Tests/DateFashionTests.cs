using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises.Tests
{
    [TestClass]
    public class DateFashionTests
    {
        [TestMethod]
        [DataRow(5, 10, 2)]
        [DataRow(5, 2, 0)]
        [DataRow(5, 5, 1)]
        [DataRow(10, 0, 0)]
        [DataRow(0, 10, 0)]
        [DataRow(3, 7, 1)]

        public void DontChaWishYourGirlfriendWasHotLikeMe(int input1, int input2, int expected)
        {
            //Arrange
            DateFashion hotDate = new DateFashion();

            //Act
            int table = hotDate.GetATable(input1, input2);

            //Assert
            Assert.AreEqual(expected, table);
        }
    }
}
