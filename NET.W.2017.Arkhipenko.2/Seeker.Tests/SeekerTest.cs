using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Seeker;

namespace Seeker.Tests
{
    [TestClass]
    public class SeekerTest
    {
        [TestMethod]
        public void FindNextBiggerNumberTestNumbers()
        {
            Assert.AreEqual(Seeker.FindNextBiggerNumber(12).Item1, 21);
            Assert.AreEqual(Seeker.FindNextBiggerNumber(513).Item1, 531);
            Assert.AreEqual(Seeker.FindNextBiggerNumber(144).Item1, 414);
            Assert.AreEqual(Seeker.FindNextBiggerNumber(414).Item1, 441);
            Assert.AreEqual(Seeker.FindNextBiggerNumber(1234321).Item1, 1241233);
            Assert.AreEqual(Seeker.FindNextBiggerNumber(10).Item1, -1);
        }

        [TestMethod]
        public void FindNextBiggerNumberTestTime()
        {
            Assert.IsFalse(Seeker.FindNextBiggerNumber(144).Item2 == null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void FindNextBiggerNumber_Number_Exception()
        {
            var x = Seeker.FindNextBiggerNumber(-5).Item1;
        }
    }
}
