using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises.Tests
{
    [TestClass]
    public class StringBitsTests
    {
        [TestMethod]
        [DataRow("", "")]
        [DataRow("Phillip", "Pilp")]
        [DataRow("Onomatopoeia", "Ooaooi")]
        [DataRow("Dude", "Dd")]
        [DataRow("What", "Wa")]
        public void BitsAndPieces(string input, string expected)
        {
            //Arrange
            StringBits words = new StringBits();

            //Act
            string letters = words.GetBits(input);

            //Assert
            Assert.AreEqual(expected, letters);
        }
    }
}
