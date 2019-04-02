using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using kyu5;

namespace Testkyu5
{
    /// <summary>
    /// Summary description for KataPaginationHelperTest
    /// </summary>
    [TestClass]
    public class KataPaginationHelperTest
    {
        private readonly IList<int> collection = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24 };
        private KataPaginationHelper<int> helper;

        [TestInitialize]
        public void Init()
        {
            helper = new KataPaginationHelper<int>(collection, 10);
        }

        [TestMethod]
        public void TestPaginationHelper()
        {
            var myHelper = new KataPaginationHelper<char>(new List<char> { 'a', 'b', 'c', 'd', 'e', 'f' }, 4);

            Assert.AreEqual(2, myHelper.PageCount);
            Assert.AreEqual(6, myHelper.ItemCount);
            Assert.AreEqual(4, myHelper.PageItemCount(0));
            Assert.AreEqual(2, myHelper.PageItemCount(1));
            Assert.AreEqual(-1, myHelper.PageItemCount(2));

            // pageIndex takes an item index and returns the page that it belongs on
            Assert.AreEqual(1, myHelper.PageIndex(5));
            Assert.AreEqual(0, myHelper.PageIndex(2));
            Assert.AreEqual(-1, myHelper.PageIndex(20));
            Assert.AreEqual(-1, myHelper.PageIndex(-1));
        }

        [TestMethod]
        public void PageItemCountTest()
        {
            Assert.AreEqual(-1, helper.PageItemCount(-1));
            Assert.AreEqual(10, helper.PageItemCount(1));
            Assert.AreEqual(-1, helper.PageItemCount(3));
        }

        [TestMethod]
        public void PageIndexTest()
        {
            Assert.AreEqual(-1, helper.PageIndex(-1));
            Assert.AreEqual(1, helper.PageIndex(12));
            Assert.AreEqual(-1, helper.PageIndex(24));
        }

        [TestMethod]
        public void ItemCountTest()
        {
            Assert.AreEqual(24, helper.ItemCount);
        }

        [TestMethod]
        public void PageCountTest()
        {
            Assert.AreEqual(3, helper.PageCount);
        }
    }
}
