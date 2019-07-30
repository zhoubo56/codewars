using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using kyu5;

namespace Testkyu5
{
    /// <summary>
    /// Summary description for JohannTest
    /// </summary>
    [TestClass]
    public class JohannTest
    {
        [TestMethod]
        public void Test1()
        {
            Console.WriteLine("Basic Tests John");
            TestJohn(11, "[0, 0, 1, 2, 2, 3, 4, 4, 5, 6, 6]");
        }

        [TestMethod]
        public void Test2()
        {
            Console.WriteLine("Basic Tests Ann");
            TestAnn(6, "[1, 1, 2, 2, 3, 3]");
        } 

        [TestMethod]
        public void Test3()
        {
            Console.WriteLine("Basic Tests SumAnn");
            TestSumAnn(115, 4070);
        }

        [TestMethod]
        public void Test4()
        {
            Console.WriteLine("Basic Tests SumJohn");
            TestSumJohn(75, 1720);
        }

        private string Array2String(List<long> list)
        {
            return "[" + string.Join(", ", list) + "]";
        }

        private void TestJohn(long n, string res)
        {
            Assert.AreEqual(res, Array2String(Johnann.John(n)));
        }

        private void TestAnn(long n, string res)
        {
            Assert.AreEqual(res, Array2String(Johnann.Ann(n)));
        }

        private void TestSumAnn(long n, long res)
        {
            Assert.AreEqual(res, Johnann.SumAnn(n));
        }

        private void TestSumJohn(long n, long res)
        {
            Assert.AreEqual(res, Johnann.SumJohn(n));
        }
    }
}
