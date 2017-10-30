using System;
using System.Collections;
using System.Collections.Generic;
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
            List<int> list = new List<int>();
            list = Filter.FilterDigit(7, 1, 2, 3, 4, 5, 6, 7, 68, 70, 15, 17);
            List<int> resultArrayList = new List<int>(){7, 70, 17};
            for (int i = 0; i < list.Count; i++)
            {
                Assert.AreEqual(list[i],resultArrayList[i]);
            }
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void FilterDigit_IfEmpty_Exception()
        {
            List<int> list = new List<int>();
            list = Filter.FilterDigit(5);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void FilterDigit_IfNull_Exception()
        {
            List<int> list = new List<int>();
            list = Filter.FilterDigit(5);
        }
    }
}
