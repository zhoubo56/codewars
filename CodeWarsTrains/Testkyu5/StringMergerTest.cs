using System;
using System.Text;
using System.Collections.Generic;
using kyu5;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testkyu5
{
    /// <summary>
    /// Summary description for StringMergerTest
    /// </summary>
    [TestClass]
    public class StringMergerTest
    {
        [TestMethod]
        public void HappyPath1()
        {
            Assert.IsTrue(StringMerger.isMerge("codewars", "code", "wars"), "codewars can be created from code and wars");
        }

        [TestMethod]
        public void HappyPath2()
        {
            Assert.IsTrue(StringMerger.isMerge("codewars", "cdwr", "oeas"), "codewars can be created from cdwr and oeas");
        }

        [TestMethod]
        public void SadPath1()
        {
            Assert.IsFalse(StringMerger.isMerge("codewars", "cod", "wars"), "Codewars are not codwars");
        }

        [TestMethod]
        public void CanHandleBananas()
        {
            Assert.IsTrue(StringMerger.isMerge("bananas", "baa", "anns"), "Going bananas!");
        }

        [TestMethod]
        public void HappyPath4()
        {
            Assert.IsTrue(StringMerger.isMerge("Can we merge it? Yes, we can!", "n ee tYw n!", "Cawe mrgi? es, eca"), "Can we merge it? Yes, we can!' is a merge of 'n ee tYw n!' and 'Cawe mrgi? es, eca");
        }
    }
}
