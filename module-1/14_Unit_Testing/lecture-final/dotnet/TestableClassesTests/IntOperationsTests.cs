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
            bool result = intOps.IsOdd(1);

            // Assert
            Assert.AreEqual(true, result);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsOdd_EvenNumbersShouldReturnFalse()
        {
            // Arrange
            IntOperations intOps = new IntOperations();

            // Act
            bool result = intOps.IsOdd(42);

            // Assert
            Assert.IsFalse(result, "Expected 42 to result in false");
        }

        [TestMethod]
        public void IsOdd_ZeroShouldReturnFalse()
        {
            // Arrange
            IntOperations intOps = new IntOperations();

            // Act
            bool result = intOps.IsOdd(0);

            // Assert
            Assert.IsFalse(result, "Expected 0 to result in false");
        }

        [TestMethod]
        public void FourShouldBeDivisibleByTwo()
        {
            // Arrange
            IntOperations ops = new IntOperations();

            // Act
            bool result = ops.AreNumbersDivisible(2, 4);

            // Assert
            Assert.AreEqual(true, result);
        }


        [TestMethod]
        public void TestZeroDivision()
        {
            // Arrange
            IntOperations ops = new IntOperations();

            // Act
            bool result = ops.AreNumbersDivisible(0, 6);

            // Assert
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void MultiplyAbsoluteShouldReturnZeroForZeros()
        {
            // Arrange
            IntOperations ops = new IntOperations();

            // Act
            int result = ops.MultiplyAbsolute(-1, 0);

            // Assert
            Assert.AreEqual(0, result);
        }


        [TestMethod]
        public void MultiplyAbsoluteShouldReturnPositiveWhenNegative()
        {
            // Arrange
            IntOperations ops = new IntOperations();

            // Act
            int result = ops.MultiplyAbsolute(-5, 3);

            // Assert
            Assert.AreEqual(15, result);
        }

        [TestMethod]
        public void MultiplyAbsoluteShouldReturnPositiveWhenPositive()
        {
            // Arrange
            IntOperations ops = new IntOperations();

            // Act
            int result = ops.MultiplyAbsolute(6, 7);

            // Assert
            Assert.AreEqual(42, result);
        }

    }
}
