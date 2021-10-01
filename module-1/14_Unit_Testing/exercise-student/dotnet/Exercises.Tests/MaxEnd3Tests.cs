using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises.Tests
{
    [TestClass]
    public class MaxEnd3Tests
    {
        [TestMethod]
        public void FilledByMax3()
        {
            //Arrange
            MaxEnd3 newList = new MaxEnd3();
            int[] numbers = new int[] { 1, 2, 3 };

            //Act
            int[] result = newList.MakeArray(numbers);

            //Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(3, result.Length);
            Assert.AreEqual(3, result[0]);
            Assert.AreEqual(3, result[1]);
            Assert.AreEqual(3, result[2]);
        }


        [TestMethod]
        public void FilledByMax13()
        {
            //Arrange
            MaxEnd3 newList = new MaxEnd3();
            int[] numbers = new int[] { 13, 7, 1 };

            //Act
            int[] result = newList.MakeArray(numbers);

            //Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(3, result.Length);
            Assert.AreEqual(13, result[0]);
            Assert.AreEqual(13, result[1]);
            Assert.AreEqual(13, result[2]);
        }


        [TestMethod]
        public void FilledByMax0()
        {
            //Arrange
            MaxEnd3 newList = new MaxEnd3();
            int[] numbers = new int[] { -5, -10, 0 };

            //Act
            int[] result = newList.MakeArray(numbers);

            //Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(3, result.Length);
            Assert.AreEqual(0, result[0]);
            Assert.AreEqual(0, result[1]);
            Assert.AreEqual(0, result[2]);
        }
    }
}

