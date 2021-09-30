using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestableClasses;

namespace TestableClassesTests
{
    [TestClass]
    public class StringOperationsTests
    {
        [TestMethod]
        public void StandardCapitalization_Test1()
        {
            //Arrange
            StringOperations strings = new StringOperations();

            //Act
            string result = strings.MakeStandardCapitalizationString("yomama");

            //Assert
            Assert.AreEqual("Yomama", result);
        }

        [TestMethod]
        [DataRow("some string", "Some string")]
        [DataRow("bruce wayne", "BATMAN")] // Who tests like this? ew.
        public void StandardCapitalization_Test1(string input, string expected)
        {
            //Arrange
            StringOperations strings = new StringOperations();

            //Act
            string result = strings.MakeStandardCapitalizationString("yomama");

            //Assert
            Assert.AreEqual("Yomama", result);
        }

        [TestMethod]
        [DataRow("Columbus", "Ohio", "Columbus, Ohio")]
        [DataRow("Orlando", "Florida", "Orlando, Florida")]
        [DataRow("Albuquerque", "New Mexico", "Albuquerque, New Mexico")]

        public void TryTheseAddresses(string input1, string input2, string expected)
        {
            //Arrange

            //Act

            //Assert
        }


        [TestMethod]
        [DataRow("some string", 2)]
        [DataRow("bruce wayne", 4)]
        [DataRow("Y~MAMA3!",2)]
        [DataRow(null,null)]
       
        public void NumberOfVowelsTest(string input, int expected)
        {
            //Arrange
            StringOperations strings = new StringOperations();

            //Act
            int result = strings.CalculateNumberOfVowels(input);

            //Assert
            Assert.AreEqual(expected, result);
        }

        
    }
}
