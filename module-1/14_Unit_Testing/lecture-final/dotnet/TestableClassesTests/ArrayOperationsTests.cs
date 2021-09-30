using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using TestableClasses;

namespace TestableClassesTests
{
    [TestClass]
    public class ArrayOperationsTests
    {
        [TestMethod]
        [DataRow(new int[] { 1, 2, 3, 4, 5 }, false)]
        [DataRow(new int[] { 42, 42 }, true)]
        [DataRow(new int[] { 42 }, true)]
        [DataRow(new int[] { }, true)]
        [DataRow(null, true)]
        public void AreAllNumbersIdenticalTests(int[] numbers, bool expected)
        {
            // Arrange
            ArrayOperations ops = new ArrayOperations();

            // Act
            bool result = ops.AreAllNumbersIdentical(numbers);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void GetLowestNumberTests()
        {
            // Arrange
            ArrayOperations ops = new ArrayOperations();
            int[] numbers = new int[] { -1, -2, -3 };

            // Act
            int result = ops.GetLowestNumber(numbers);

            // Assert
            Assert.AreEqual(-3, result);
        }

        [TestMethod]
        public void ReverseArrayShouldSwapEnds()
        {
            // Arrange
            ArrayOperations arrOps = new ArrayOperations();
            int[] numbers = new int[] { 1, 2, 3 };

            // Act
            int[] result = arrOps.ReverseArray(numbers);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(3, result.Length);
            Assert.AreEqual(3, result[0]);
            Assert.AreEqual(2, result[1]);
            Assert.AreEqual(1, result[2]);

            int[] expected = new int[] { 3, 2, 1 };
            CollectionAssert.AreEqual(expected, result);

            
        }
    }
}
