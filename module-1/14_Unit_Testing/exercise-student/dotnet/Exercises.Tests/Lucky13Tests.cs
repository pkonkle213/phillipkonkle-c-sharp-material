using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises.Tests
{
    [TestClass]
    public class Lucky13Tests
    {
        [TestMethod]
        [DataRow(new int[] { 2, 4, 6, 8, 10, 12 }, true)]
        [DataRow(new int[] { 1 }, false)]
        [DataRow(new int[] { }, true)]
        [DataRow(new int[] { 3, 2, 1 }, false)]

        public void NoWhammiesNoWhammies(int[] input, bool expected)
        {
            //Arrange
            Lucky13 hopefully = new Lucky13();

            //Act
            bool confirmation = hopefully.GetLucky(input);

            //Assert
            Assert.AreEqual(expected, confirmation);
        }
    }
}
