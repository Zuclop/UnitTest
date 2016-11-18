using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass]
    public class TestSplit
    {
        [TestMethod]
        public void TestSplitFewSeparators()
        {
            //Arrange
            string source = "TestSubstring";
            char[] separators = new char[] { 'T', 'g' };
            string[] exp = new string[] { "", "estSubstrin", "" };

            //Act
            string[] res = source.Split(separators);

            //Assert
            CollectionAssert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestSplitNonExistSeparators()
        {
            //Arrange
            string source = "TestSubstring";
            char[] separators = new char[] { 'a', 'z' };
            string[] exp = new string[] { "TestSubstring" };

            //Act
            string[] res = source.Split(separators);

            //Assert
            CollectionAssert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestSplitEmptySeparators()
        {
            //Arrange
            string source = "TestSubstring";
            char[] separators = new char[] { };
            string[] exp = new string[] { "TestSubstring" };

            //Act
            string[] res = source.Split(separators);

            //Assert
            CollectionAssert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestSplitNullSeparators()
        {
            //Arrange
            string source = "TestSubstring";
            char[] separators = null;
            string[] exp = new string[] { "TestSubstring" };

            //Act
            string[] res = source.Split(separators);

            //Assert
            CollectionAssert.AreEqual(exp, res);
        }
    }
}
