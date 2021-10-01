using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises.Tests
{
    [TestClass]
    public class NonStartTests
    {
        [TestMethod]
        [DataRow("Phillip", "Konkle", "hilliponkle")]
        [DataRow("Magic", "cards", "agicards")]
        [DataRow("P", "K", "")]
        public void elloOvnor(string input1, string input2, string expected)
        {
            //Arrange
            NonStart words = new NonStart();
            //Act
            string letters = words.GetPartialString(input1, input2);
            //Assert
            Assert.AreEqual(expected, letters);
        }
    }
}
