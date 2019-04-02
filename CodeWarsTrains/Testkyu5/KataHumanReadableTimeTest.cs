using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using kyu5;

namespace Testkyu5
{
    /// <summary>
    /// Summary description for KataHumanReadableTimeTest
    /// </summary>
    [TestClass]
    public class KataHumanReadableTimeTest
    {
        [TestMethod]
        public void TestGetReadableTime()
        {
            Assert.AreEqual("00:00:00", KataHumanReadableTime.GetReadableTime(0));
            Assert.AreEqual("00:00:05", KataHumanReadableTime.GetReadableTime(5));
            Assert.AreEqual("00:01:00", KataHumanReadableTime.GetReadableTime(60));
            Assert.AreEqual("23:59:59", KataHumanReadableTime.GetReadableTime(86399));
            Assert.AreEqual("99:59:59", KataHumanReadableTime.GetReadableTime(359999));
        }
    }
}
