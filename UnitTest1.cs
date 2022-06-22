using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab4;
using System;

namespace UnitTest
{
    [TestClass]
    public class ValidatorTest
    {
        [TestMethod]
        public void ValidatorCreateTest()
        {
            Validator validator = new Validator();
            Assert.IsNotNull(validator);
        }

        [TestMethod]
        public void ReturnSnilsTest()
        {
            var validator = new Validator();
            string expected = "12345";
            Assert.AreEqual(expected, validator.snils);
        }
    }
}
