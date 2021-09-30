using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using TestableClasses;

namespace TestableClassesTests
{
    [TestClass]
    public class DictionaryOperationsTests
    {
        [TestMethod]
        public void WordLengthsShouldCalculateCorrectly()
        {
            // Arrange
            DictionaryOperations ops = new DictionaryOperations();
            string[] words = new string[] {
                "Everyone",
                "looks",
                "angry"
            };

            // Act
            Dictionary<string, int> result = ops.GetWordLengths(words);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(3, result.Count);
            Assert.IsTrue(result.ContainsKey("angry"));
            Assert.AreEqual(5, result["angry"]);
        }
    }
}
