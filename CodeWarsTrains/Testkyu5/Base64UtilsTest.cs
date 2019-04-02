using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using kyu5;

namespace Testkyu5
{
    /// <summary>
    /// Summary description for Base64UtilsTest
    /// </summary>
    [TestClass]
    public class Base64UtilsTest
    {
        [TestMethod]
        public void TestToBase64()
        {
            Assert.AreEqual("TWFu", Base64Utils.ToBase64("Man"));
            Assert.AreEqual("dGhpcyBpcyBhIHN0cmluZyEh", Base64Utils.ToBase64("this is a string!!"));
            Assert.AreEqual("ZWU=", Base64Utils.ToBase64("ee"));
            Assert.AreEqual("ZQ==", Base64Utils.ToBase64("e"));
            Assert.AreEqual("", Base64Utils.ToBase64(""));
        }

        [TestMethod]
        public void TestFromBase64()
        {
            Assert.AreEqual("A", Base64Utils.FromBase64("QQ=="));
            Assert.AreEqual("Man", Base64Utils.FromBase64("TWFu"));
            Assert.AreEqual("this is a string!!", Base64Utils.FromBase64("dGhpcyBpcyBhIHN0cmluZyEh"));
            Assert.AreEqual("ee", Base64Utils.FromBase64("ZWU="));
            Assert.AreEqual("e", Base64Utils.FromBase64("ZQ=="));
            Assert.AreEqual("", Base64Utils.FromBase64(""));
        }
    }
}
