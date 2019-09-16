using System.Linq;
using kyu3;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testkyu3
{
    [TestClass]
    public class PrimeStreamingTest
    {
        [TestMethod]
        public void Test_10_10()
        {
            Test(10, 10, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71);
        }

        [TestMethod]
        public void Test_100_10()
        {
            Test(100, 10, 547, 557, 563, 569, 571, 577, 587, 593, 599, 601);
        }

        [TestMethod]
        public void Test_1000_10()
        {
            Test(1000, 10, 7927, 7933, 7937, 7949, 7951, 7963, 7993, 8009, 8011, 8017);
        }


        private static void Test(int skip, int limit, params int[] expect)
        {
            var stream = PrimeStreaming.Stream();
            var found = stream.Skip(skip).Take(limit).ToArray();
            CollectionAssert.AreEqual(expect, found);
        }
    }
}
