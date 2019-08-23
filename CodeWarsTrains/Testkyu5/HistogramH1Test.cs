﻿using kyu5;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testkyu5
{
    [TestClass]
    public class HistogramH1Test
    {
        [TestMethod]
        public void TestMethod1()
        {
            string expected =
                "6|##### 5\n" +
                "5|\n" +
                "4|# 1\n" +
                "3|########## 10\n" +
                "2|### 3\n" +
                "1|####### 7\n";
            Assert.AreEqual(expected, HistogramH1.Histogram(new int[] { 7, 3, 10, 1, 0, 5 }));
        }
    }
}
