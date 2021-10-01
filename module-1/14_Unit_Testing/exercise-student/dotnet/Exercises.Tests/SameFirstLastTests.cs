using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises.Tests
{
    [TestClass]
    public class SameFirstLastTests
    {
        [TestMethod]
        [DataRow(new int[] { 1, 2, 1 }, true)]
        [DataRow(new int[] { 1, 2, 2, 1 }, true)]
        [DataRow(new int[] { 1, 2, 3, 2, 1 }, true)]
        [DataRow(new int[] { 5, 4, 3, 2, 1 }, false)]
        [DataRow(new int[] { -2, -1, 0, 1, 2 }, false)]
        public void TheBeginningIsTheEndIsTheBeginning(int[] input, bool expected)
        {
            // Arrange
            SameFirstLast copyCopy = new SameFirstLast();
            int[] numbers = input;

            // Act
            bool result = copyCopy.IsItTheSame(numbers);

            // Assert
            Assert.AreEqual(expected, result);

        }
    }
}
