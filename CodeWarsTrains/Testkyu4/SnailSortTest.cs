using System;
using System.Linq;
using kyu4;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testkyu4
{
    /// <summary>
    /// Summary description for SnailSortTest
    /// </summary>
    [TestClass]
    public class SnailSortTest
    {
        [TestMethod]
        public void SnailTest1()
        {
            int[][] array =
            {
                new []{1, 2, 3},
                new []{4, 5, 6},
                new []{7, 8, 9}
            };
            var r = new[] { 1, 2, 3, 6, 9, 8, 7, 4, 5 };
            Test(array, r);
        }

        [TestMethod]
        public void SnailTest2()
        {
            int[][] array =
            {
                new []{1, 2, 3, 4},
                new []{5, 6, 7, 8},
                new []{9, 10, 11, 12},
                new []{13, 14, 15, 16}
            };
            var r = new[] { 1, 2, 3, 4, 8, 12, 16, 15, 14, 13, 9, 5, 6, 7, 11, 10 };
            Test(array, r);
        }

        public string Int2DToString(int[][] a)
        {
            return $"[{string.Join("\n", a.Select(row => $"[{string.Join(",", row)}]"))}]";
        }

        public void Test(int[][] array, int[] result)
        {
            var text = $"{Int2DToString(array)}\nshould be sorted to\n[{string.Join(",", result)}]\n";
            Console.WriteLine(text);
            CollectionAssert.AreEqual(result, SnailSort.Snail(array));
        }
    }
}
