using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises.Tests
{
    [TestClass]
    public class Less20Tests
    {
        [TestMethod]
        [DataRow(20, false)]
        [DataRow(21, false)]
        [DataRow(22, false)]
        [DataRow(38, true)]
        [DataRow(39, true)]
        public void SoCloseNoCigar(int input, bool expected)
        {
            Less20 newNum = new Less20();

            bool tester = newNum.IsLessThanMultipleOf20(input);

            Assert.AreEqual(expected, tester);
        }
    }
}
