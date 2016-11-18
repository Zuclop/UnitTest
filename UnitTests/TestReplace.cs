using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass]
    public class TestReplace
    {
        [TestMethod]
        public void TestReplaceFewTimes()
        {
            //Arrange
            string source = "TestSubstring";
            char oldChar = 's';
            char newChar = 'S';
            string exp = "TeStSubString";

            //Act
            string res = source.Replace(oldChar, newChar);

            //Assert
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestReplaceZeroTimes()
        {
            //Arrange
            string source = "TestSubstring";
            char oldChar = 'Z';
            char newChar = 'S';
            string exp = "TestSubstring";

            //Act
            string res = source.Replace(oldChar, newChar);

            //Assert
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestReplaceTheSame()
        {
            //Arrange
            string source = "TestSubstring";
            char oldChar = 's';
            char newChar = 's';
            string exp = "TestSubstring";

            //Act
            string res = source.Replace(oldChar, newChar);

            //Assert
            Assert.AreEqual(exp, res);
        }
    }
}
