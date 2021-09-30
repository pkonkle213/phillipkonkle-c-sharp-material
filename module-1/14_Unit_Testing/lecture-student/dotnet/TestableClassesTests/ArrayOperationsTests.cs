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
        public void AreAllNumbersIdenticalTests()
        {
            //Arrange
            ArrayOperations ops = new ArrayOperations();
            int[] numbers = new int[] { 1, 2, 3, 4, 5 };

            //Act
            bool result = ops.AreAllNumbersIdentical(numbers);

            //Assert
            Assert.AreEqual(false, result);
        }
    }
}
