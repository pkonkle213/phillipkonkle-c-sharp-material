using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises.Tests
{
    [TestClass]
    public class FrontTimesTests
    {
        [TestMethod]
        [DataRow("Phillip",3,"PhiPhiPhi")]
        [DataRow("",100,"")]
        [DataRow("a",5,"aaaaa")]
        [DataRow(null)]
        [DataRow("hi",20, "hihihihihihihihihihihihihihihihihihihihi")]
        public void FirstThreeCharactersAreRepeated(string input1, int input2, string expected)
        {
            //Arrange
            FrontTimes letters = new FrontTimes();

            //Act
            string chooBaby = letters.GenerateString(input1, input2);

            //Assert
            Assert.AreEqual(expected, chooBaby);
        }
    }
    
}
