using System;
using System.Collections;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FilterDigitLib;


namespace FilterDigitLib.Tests
{
    [TestClass]
    public class FilterTests
    {
        [TestMethod]
        public void FilterDigitTest()
        {
            ArrayList list = new ArrayList();
            list = Filter.FilterDigit(7, 1, 2, 3, 4, 5, 6, 7, 68, 70, 15, 17);
            ArrayList resultArrayList = new ArrayList(){7, 70, 17};
            for (int i = 0; i < list.Count; i++)
            {
                Assert.AreEqual(list[i],resultArrayList[i]);
            }
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void FilterDigit_IfEmpty_Exception()
        {
            ArrayList list = new ArrayList();
            list = Filter.FilterDigit(5);
        }
    }
}
