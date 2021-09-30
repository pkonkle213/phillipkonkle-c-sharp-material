using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercises.Tests
{
    [TestClass]
    public class AnimalGroupNameTests
    {
        [TestMethod]
        [DataRow("ElEpHaNt","Herd")]
        [DataRow(null)]
        [DataRow("Phillip", "unknown")]
        [DataRow("", "unknown")]
        public void TermsForGroupsOfAnimals(string input, string expected)
        {
            //Arrange
            AnimalGroupName animals = new AnimalGroupName();

            //Act
            string ribbit = animals.GetHerd(input);

            //Assert
            Assert.AreEqual(expected, ribbit);
        }
    }
}
