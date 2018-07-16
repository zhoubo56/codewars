using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testkyu8
{
    [TestClass]
    public class KataReplaceVowelTest
    {
        [TestMethod]
        public void TestReplace()
        {
            Assert.AreEqual("H!!", KataReplaceVowel.Replace("Hi!"));
            Assert.AreEqual("!H!! H!!", KataReplaceVowel.Replace("!Hi! Hi!"));
            Assert.AreEqual("!!!!!", KataReplaceVowel.Replace("aeiou"));
            Assert.AreEqual("!BCD!", KataReplaceVowel.Replace("ABCDE"));
        }
    }
}
