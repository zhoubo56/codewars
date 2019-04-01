using System;
using kyu5;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testkyu5
{
    [TestClass]
    public class KataDirectionsReductionTest
    {
        [TestMethod]
        public void Test1()
        {
            string[] a = new string[] { "NORTH", "SOUTH", "SOUTH", "EAST", "WEST", "NORTH", "WEST" };
            string[] b = new string[] { "WEST" };
            CollectionAssert.AreEqual(b, KataDirectionsReduction.dirReduc(a));
        }

        [TestMethod]
        public void Test2()
        {
            string[] a = new string[] { "NORTH", "WEST", "SOUTH", "EAST" };
            string[] b = new string[] { "NORTH", "WEST", "SOUTH", "EAST" };
            CollectionAssert.AreEqual(b, KataDirectionsReduction.dirReduc(a));
        }
    }
}
