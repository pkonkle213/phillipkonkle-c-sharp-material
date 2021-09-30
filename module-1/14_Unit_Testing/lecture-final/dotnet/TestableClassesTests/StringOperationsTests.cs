using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using TestableClasses;

namespace TestableClassesTests
{
    [TestClass]
    public class StringOperationsTests
    {
        [TestMethod]
        public void DotNetShouldCapitalizeCorrectly()
        {
            // Arrange
            // SUT = System Under Test
            StringOperations sut = new StringOperations();
            string input = "DotNet";

            // Act
            string result = sut.MakeStandardCapitalizationString(input);

            // Assert
            Assert.AreEqual("Dotnet", result);
        }

        [TestMethod]
        public void EmptyStringShouldCapitalizeCorrectly()
        {
            // Arrange
            // SUT = System Under Test
            StringOperations sut = new StringOperations();
            string input = "";

            // Act
            string result = sut.MakeStandardCapitalizationString(input);

            // Assert
            Assert.AreEqual("", result);
        }

        [TestMethod]
        public void IShouldCapitalizeCorrectly()
        {
            // Arrange
            // SUT = System Under Test
            StringOperations sut = new StringOperations();
            string input = "I";

            // Act
            string result = sut.MakeStandardCapitalizationString(input);

            // Assert
            Assert.AreEqual("I", result);
        }


        [TestMethod]
        [DataRow("some string", "Some string")]
        [DataRow("bruce wayne", "Bruce wayne")]
        public void CapitalizationShouldWorkCorrectly(string input, string expected)
        {
            // Arrange
            // SUT = System Under Test
            StringOperations sut = new StringOperations();

            // Act
            string result = sut.MakeStandardCapitalizationString(input);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        [DataRow("Westerville", "OH", "Westerville, OH")]
        [DataRow("!!!", "###", "!!!, ###")]
        [DataRow("", "", ", ")]
        [DataRow(null, null, ", ")]
        public void AddressTests(string city, string state, string expected)
        {
            // Arrange
            StringOperations ops = new StringOperations();

            // Act
            string result = ops.GetAddressString(city, state);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        [DataRow("BATMAN", 2)]
        [DataRow("Adam West", 3)]
        [DataRow(" ", 0)]
        [DataRow("", 0)]
        [DataRow("!@$#%", 0)]
        [DataRow(null, 0)]
        public void VowelTests(string input, int expected)
        {
            // Arrange
            StringOperations ops = new StringOperations();

            // Act
            int result = ops.CalculateNumberOfVowels(input);

            // Assert
            Assert.AreEqual(expected, result);
        }
    }
}
