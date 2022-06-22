using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab4;
using System;

namespace UnitTest
{
    [TestClass]
    public class ValidatorTest
    {

        [TestMethod]
        public void ReturnSnilsTest()
        {
            long expected = 12345678901;
            Assert.AreEqual(expected, Validator.ConvertSnils("12345678901"));
        }

        [TestMethod]
        public void ValidateChecksumBelowMinTest()
        {
            bool actual = Validator.ValidateChecksum("00000000001");
            Assert.AreEqual(true, actual);
        }

        [TestMethod]
        public void ValidateChecksumSumLess100Test()
        {
            bool actual = Validator.ValidateChecksum("00100199864");
            Assert.AreEqual(true, actual);
        }

        [TestMethod]
        public void ValidateChecksumSumEquals100Test()
        {
            bool actual = Validator.ValidateChecksum("12346000000");
            Assert.AreEqual(true, actual);
        }

        [TestMethod]
        public void ValidateChecksumSumMore100Test()
        {
            bool actual = Validator.ValidateChecksum("12345678964");
            Assert.AreEqual(true, actual);
        }

        [TestMethod]
        public void ValidateNumbersCountTest()
        {
            bool actual = Validator.ValidateNumbersCount("12345678964");
            Assert.AreEqual(true, actual);
        }

        [TestMethod]
        public void ValidateDigitsTest()
        {
            bool actual = Validator.ValidateDigits("1b234a78c64");
            Assert.AreEqual(false, actual);
        }

        [TestMethod]
        public void NumbersInRowTest()
        {
            bool actual = Validator.NumbersInRow("12346000000");
            Assert.AreEqual(false, actual);
        }

        [TestMethod]
        public void ValidateTest()
        {
            string expected = "СНИЛС прошел проверку";
            string actual = Validator.Validate("12345678964");
            Assert.AreEqual(expected, actual);
        }
    }
}
