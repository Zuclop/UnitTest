using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass]
    public class TestSubstring
    {
        [TestMethod]
        public void TestSubstringFromZero()
        {
            //Arrange
            string source = "TestSubstring";
            int fromIndex = 0;
            string exp = "TestSubstring";

            //Act
            string res = source.Substring(fromIndex);

            //Assert
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestSubstringFromLast()
        {
            //Arrange
            string source = "TestSubstring";
            int fromIndex = source.Length;
            string exp = "";

            //Act
            string res = source.Substring(fromIndex);

            //Assert
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestSubstringFromTooLong()
        {
            //Arrange
            string source = "TestSubstring";
            int fromIndex = source.Length + 1;
            string exp = null;

            //Act
            string res = source.Substring(fromIndex);

            //Assert
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestSubstringFromNegative()
        {
            //Arrange
            string source = "TestSubstring";
            int fromIndex = -1;
            string exp = null;

            //Act
            string res = source.Substring(fromIndex);

            //Assert
            Assert.AreEqual(exp, res);
        }       
    }
}
