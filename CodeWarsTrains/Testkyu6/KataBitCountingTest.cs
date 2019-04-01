using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using kyu6;

namespace Testkyu6
{
    [TestClass]
    public class KataBitCountingTest
    {
        [TestMethod]
        public void TestCountBits()
        {
            Assert.AreEqual(0, KataBitCounting.CountBits(0));
            Assert.AreEqual(1, KataBitCounting.CountBits(4));
            Assert.AreEqual(3, KataBitCounting.CountBits(7));
            Assert.AreEqual(2, KataBitCounting.CountBits(9));
            Assert.AreEqual(2, KataBitCounting.CountBits(10));
        }
    }
}
