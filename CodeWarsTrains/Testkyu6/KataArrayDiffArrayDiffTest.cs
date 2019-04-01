using System;
using kyu6;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testkyu6
{
    [TestClass]
    public class KataArrayDiffArrayDiffTest
    {
        [TestMethod]
        public void TestArrayDiff()
        {
            //此单元测试无法通过，但是网站上的单元测试没问题，原因不明！！！
            //需要使用CollectionAssert代替Assert
            CollectionAssert.AreEqual(new int[] { 2 }, KataArrayDiff.ArrayDiff(new int[] { 1, 2 }, new int[] { 1 }));
            CollectionAssert.AreEqual(new int[] { 2, 2 }, KataArrayDiff.ArrayDiff(new int[] { 1, 2, 2 }, new int[] { 1 }));
            CollectionAssert.AreEqual(new int[] { 1 }, KataArrayDiff.ArrayDiff(new int[] { 1, 2, 2 }, new int[] { 2 }));
            CollectionAssert.AreEqual(new int[] { 1, 2, 2 }, KataArrayDiff.ArrayDiff(new int[] { 1, 2, 2 }, new int[] { }));
            CollectionAssert.AreEqual(new int[] { }, KataArrayDiff.ArrayDiff(new int[] { }, new int[] { 1, 2 }));
        }
    }
}
