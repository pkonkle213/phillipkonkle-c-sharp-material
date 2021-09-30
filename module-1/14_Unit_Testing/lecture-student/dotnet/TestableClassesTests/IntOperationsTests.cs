using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestableClasses;

namespace TestableClassesTests
{
    [TestClass]
    public class IntOperationsTests
    {
        [TestMethod]
        public void IsOdd_OddNumbersShouldReturnTrue()
        {
            // Arrange
            IntOperations intOps = new IntOperations();

            // Act
            bool result = intOps.IsOdd(13);

            // Assert
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void AbsoluteMultiplyOneNegative()
        {
            // Arrange
            IntOperations multiply = new IntOperations();

            // Act
            int result = multiply.MultiplyAbsolute(-1, 13);

            // Assert
            Assert.AreEqual(13, result);
        }

        [TestMethod]
        public void AbsoluteMultiplyTwoNegative()
        {
            // Arrange
            IntOperations multiply = new IntOperations();

            // Act
            int result = multiply.MultiplyAbsolute(-21, -1);

            // Assert
            Assert.AreEqual(21, result);
        }

        [TestMethod]
        public void AbsoluteMultiplyZeroNegative()
        {
            // Arrange
            IntOperations multiply = new IntOperations();

            // Act
            int result = multiply.MultiplyAbsolute(21, 2);

            // Assert
            Assert.AreEqual(42, result);
        }


    }
}
