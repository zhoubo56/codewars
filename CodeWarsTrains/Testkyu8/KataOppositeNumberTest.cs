using System;
using kyu8;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testkyu8
{
    [TestClass]
    public class KataOppositeNumberTest
    {
        [TestMethod]
        public void TestOpposite()
        {
            Assert.AreEqual(-1, KataOppositeNumber.Opposite(1));
        }
    }
}
