using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises.Tests
{
    [TestClass]
    public class CigarPartyTests
    {
        [TestMethod]
        [DataRow(0, true, false)]
        [DataRow(61, true, true)]
        [DataRow(61, false, false)]
        [DataRow(50, false, true)]
        [DataRow(39, true, false)]
        public void CigarsAndPartiesAreBadForYourHealth(int input1, bool input2, bool expected)
        {
            //Arrange
            CigarParty party = new CigarParty();

            //Act
            bool greatSuccess = party.HaveParty(input1, input2);

            //Assert
            Assert.AreEqual(expected, greatSuccess);
        }
    }
}
