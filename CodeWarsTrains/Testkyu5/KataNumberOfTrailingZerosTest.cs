using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using kyu5;

namespace Testkyu5
{
    /// <summary>
    /// Summary description for KataNumberOfTrailingZerosTest
    /// </summary>
    [TestClass]
    public class KataNumberOfTrailingZerosTest
    {
        [TestMethod]
        public void TestTrailingZeros()
        {
            Assert.AreEqual(1, KataNumberOfTrailingZeros.TrailingZeros(5));
            Assert.AreEqual(6, KataNumberOfTrailingZeros.TrailingZeros(25));
            Assert.AreEqual(131, KataNumberOfTrailingZeros.TrailingZeros(531));
        }
    }
}
