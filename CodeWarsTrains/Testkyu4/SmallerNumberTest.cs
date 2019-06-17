using kyu4;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testkyu4
{
    [TestClass]
    public class SmallerNumberTest
    {
        [TestMethod]
        public void TestNextSmaller()
        {
            //SampleTests
            Assert.AreEqual(12, SmallerNumber.NextSmaller(21));
            Assert.AreEqual(790, SmallerNumber.NextSmaller(907));
            Assert.AreEqual(513, SmallerNumber.NextSmaller(531));
            Assert.AreEqual(-1, SmallerNumber.NextSmaller(1027));
            Assert.AreEqual(414, SmallerNumber.NextSmaller(441));
            Assert.AreEqual(123456789, SmallerNumber.NextSmaller(123456798));

            //FixedTests
            Assert.AreEqual(20990, SmallerNumber.NextSmaller(29009));
            Assert.AreEqual(153, SmallerNumber.NextSmaller(315));
            Assert.AreEqual(144, SmallerNumber.NextSmaller(414));
            Assert.AreEqual(59884848459853, SmallerNumber.NextSmaller(59884848483559L));

            //RandomTests
            Assert.AreEqual(51226262627551, SmallerNumber.NextSmaller(51226262651257L));
            Assert.AreEqual(28062, SmallerNumber.NextSmaller(28206));
            Assert.AreEqual(850912544212556627, SmallerNumber.NextSmaller(850912544212556672));
        }
    }
}
