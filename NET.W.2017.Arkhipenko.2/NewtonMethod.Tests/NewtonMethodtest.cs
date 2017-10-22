using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NewtonMethod;

namespace NewtonMethod.Tests
{
    [TestClass]
    public class NewtonMethodtest
    {
        [TestMethod]
        public void SqrtNewtonMetodTest()
        {
            Assert.AreEqual(SqrtNewtonMethod.FindNthRoot(8, 3, 0.0001), 2);
            Assert.AreEqual(SqrtNewtonMethod.FindNthRoot(1, 5, 0.0001), 1);
            Assert.AreEqual(SqrtNewtonMethod.FindNthRoot(0.001, 3, 0.0001), 0.1);
            Assert.AreEqual(SqrtNewtonMethod.FindNthRoot(0.04100625, 4, 0.0001), 0.45);
            Assert.AreEqual(SqrtNewtonMethod.FindNthRoot(-0.008, 3, 0.1), -0.2);
            Assert.AreEqual(SqrtNewtonMethod.FindNthRoot(0.004241979, 9, 0.00000001), 0.545);
        }
    }
}
