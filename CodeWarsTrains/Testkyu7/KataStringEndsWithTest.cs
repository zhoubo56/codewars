using System;
using kyu7;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testkyu7
{
    [TestClass]
    public class KataStringEndsWithTest
    {
        [TestMethod]
        public void TestSolution()
        {
            Assert.AreEqual(true, KataStringEndsWith.Solution("samurai", "ai"));
            Assert.AreEqual(false, KataStringEndsWith.Solution("sumo", "omo"));
            Assert.AreEqual(true, KataStringEndsWith.Solution("ninja", "ja"));
            Assert.AreEqual(true, KataStringEndsWith.Solution("sensei", "i"));
            Assert.AreEqual(false, KataStringEndsWith.Solution("samurai", "ra"));
            Assert.AreEqual(false, KataStringEndsWith.Solution("abc", "abcd"));
            Assert.AreEqual(false, KataStringEndsWith.Solution("ails", "fails"));
            Assert.AreEqual(true, KataStringEndsWith.Solution("fails", "ails"));
            Assert.AreEqual(false, KataStringEndsWith.Solution("this", "fails"));
        }
    }
}
