using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        private bool IsTextMinMaxValueValid(string Text, int MinLength, int MaxLength)
        {
            bool result = true;

            if (Text.Length < MinLength || Text.Length > MaxLength)
                result = false;

            return result;
        }

        private bool IsTextContainNumber(string Text)
        {
            return Text.All(x => Char.IsDigit(x));
        }



        [TestMethod]
        public void TestMethod1()
        {
            var actual = IsTextMinMaxValueValid("123712893", 2, 5);

            Assert.AreEqual(false, actual);
        }

        [TestMethod]
        public void TestMethod2()
        {
            var actual = IsTextMinMaxValueValid("123712893", 2, 15);

            Assert.AreEqual(true, actual);
        }

        [TestMethod]
        public void TestMethod3()
        {
            var actual = IsTextContainNumber("123712893");

            Assert.AreEqual(true, actual);
        }

        [TestMethod]
        public void TestMethod4()
        {
            var actual = IsTextContainNumber("ddfs123");

            Assert.AreEqual(false, actual);
        }
    }
}
