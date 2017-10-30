using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumberHelper;

namespace NumberHelper.Tests
{
    [TestClass]
    public class NumberHelperTest
    {
        [TestMethod]
        [ExpectedException(typeof (ArgumentException))]
        public void InsertNumber_InputParamI_Exception()
        {
            NumberHelper.InsertNumber(8, 10, -5, 2);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void InsertNumber_InputParamJ_Exception()
        {
            NumberHelper.InsertNumber(8, 10, 2, -6);
        }

        [TestMethod]
        public void InsertNumberTest1()
        {
            Assert.AreEqual(NumberHelper.InsertNumber(15, 15, 0, 0), 15);
            Assert.AreEqual(NumberHelper.InsertNumber(8, 15, 3, 8), 120);
        }
        
    }
}
