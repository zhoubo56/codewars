using kyu4;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testkyu4
{
    [TestClass]
    public class BiggerNumberTest
    {
        [TestMethod]
        public void TestNextBiggerNumber()
        {
            //SampleTests
            //Assert.AreEqual(21, BiggerNumber.NextBiggerNumber(12));
            //Assert.AreEqual(531, BiggerNumber.NextBiggerNumber(513));
            //Assert.AreEqual(2071, BiggerNumber.NextBiggerNumber(2017));
            Assert.AreEqual(441, BiggerNumber.NextBiggerNumber(414));
            Assert.AreEqual(414, BiggerNumber.NextBiggerNumber(144));
        }
    }
}
