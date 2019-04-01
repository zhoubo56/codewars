using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using kyu6;

namespace Testkyu6
{
    /// <summary>
    /// Summary description for KataFindUniqueNumberTest
    /// </summary>
    [TestClass]
    public class KataFindUniqueNumberTest
    {
        [TestMethod]
        public void TestGetUnique()
        {
            Assert.AreEqual(1, KataFindUniqueNumber.GetUnique(new[] { 1, 2, 2, 2 }));
            Assert.AreEqual(-2, KataFindUniqueNumber.GetUnique(new[] { -2, 2, 2, 2 }));
            Assert.AreEqual(14, KataFindUniqueNumber.GetUnique(new[] { 11, 11, 14, 11, 11 }));
        }
    }
}
