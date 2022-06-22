using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab4;
using System;

namespace UnitTest
{
    [TestClass]
    public class ValidatorTest
    {

        Validator validator;

        [TestInitialize]
        public void ValidatorCreateTest()
        {
            validator = new Validator("12345678901");
            Assert.IsNotNull(validator);
        }

        [TestMethod]
        public void ReturnSnilsTest()
        {
            long expected = 12345678901;
            Assert.AreEqual(expected, validator.ConvertSnils());
        }

        [TestMethod]
        public void ValidateChecksumBelowMinTest()
        {
            Validator validatorTest = new Validator("00000000001");
            bool actual = validatorTest.ValidateChecksum();
            Assert.AreEqual(false, actual);
        }
        [TestMethod]
        public void ValidateChecksumSumLess100Test()
        {
            Validator validatorTest = new Validator("00100199864");
            bool actual = validatorTest.ValidateChecksum();
            Assert.AreEqual(true, actual);
        }
    }
}
