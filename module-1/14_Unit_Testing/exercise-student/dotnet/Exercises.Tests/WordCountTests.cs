using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises.Tests
{
    [TestClass]
    public class WordCountTests
    {
        [TestMethod]
        public void EnsuringWordCountIsAccurate()
        {
            //Arrange
            WordCount newDictionary = new WordCount();
            string[] words = new string[]
            {
                "Can",
                "Can",
                "You",
                "You",
                "You",
                "Please",
                "Work",
                "Work",
            };

            //Act
            Dictionary<string, int> result = newDictionary.GetCount(words);

            //Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(4, result.Count);
            Assert.IsTrue(result.ContainsKey("You"));
            Assert.AreEqual(3, result["You"]);
            Assert.IsTrue(result.ContainsKey("Can"));
            Assert.AreEqual(2, result["Can"]);
            Assert.IsTrue(result.ContainsKey("Please"));
            Assert.AreEqual(1, result["Please"]);
        }
    }
}
