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
    }
}
