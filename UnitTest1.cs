﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
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
        [TestMethod]
        public void ValidateChecksumSumEquals100Test()
        {
            Validator validatorTest = new Validator("12346000000");
            bool actual = validatorTest.ValidateChecksum();
            Assert.AreEqual(true, actual);
        }
        [TestMethod]
        public void ValidateChecksumSumMore100Test()
        {
            Validator validatorTest = new Validator("12345678964");
            bool actual = validatorTest.ValidateChecksum();
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
            Validator validatorTest = new Validator("12346000000");
            bool actual = validatorTest.NumbersInRow("12346000000");
            Assert.AreEqual(false, actual);
        }
    }
}
