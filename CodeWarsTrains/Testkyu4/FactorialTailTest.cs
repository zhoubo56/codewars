using kyu4;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testkyu4
{
    [TestClass]
    public class FactorialTailTest
    {
        [TestMethod]
        public void Basic_Quirks()
        {
            Assert.AreEqual(2, FactorialTail.zeroes(40, 10));
        }

        [TestMethod]
        public void Can_Be_Solved_With_Basic_Computations()
        {
            Assert.AreEqual(2, FactorialTail.zeroes(10, 10));
            Assert.AreEqual(3, FactorialTail.zeroes(16, 16));
        }

        [TestMethod]
        public void Considers_Full_Base_Decomposition()
        {
            Assert.AreEqual(10, FactorialTail.zeroes(12, 26));
            Assert.AreEqual(11, FactorialTail.zeroes(12, 27));
            Assert.AreEqual(12, FactorialTail.zeroes(12, 28));
            Assert.AreEqual(14, FactorialTail.zeroes(12, 32));
            Assert.AreEqual(15, FactorialTail.zeroes(12, 33));
            Assert.AreEqual(10, FactorialTail.zeroes(80, 49));
            Assert.AreEqual(11, FactorialTail.zeroes(80, 50));
        }

        [TestMethod]
        public void Pushes_To_The_Limits()
        {
            Assert.AreEqual(524287, FactorialTail.zeroes(2, 524288));
        }

        [TestMethod]
        public void Random_Samples()
        {
            Assert.AreEqual(457, FactorialTail.zeroes(128, 3209));
        }

        [TestMethod]
        public void Relatively_Big_Prime_In_Base()
        {
            Assert.AreEqual(5, FactorialTail.zeroes(17, 100));
        }
    }
}
