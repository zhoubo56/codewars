using kyu4;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testkyu4
{
    [TestClass]
    public class MahjongPureHandTest
    {
        [TestMethod]
        public void SampleTest1()
        {
            Assert.AreEqual("9", MahjongPureHand.Solution("1122334455669"));
            Assert.AreEqual("89", MahjongPureHand.Solution("1113335557779"));
        }

        [TestMethod]
        public void SampleTest2()
        {
            Assert.AreEqual("258", MahjongPureHand.Solution("1223334455678"));
        }

        [TestMethod]
        public void FixedTests()
        {
            Assert.AreEqual("58", MahjongPureHand.Solution("1111223346788"));
            Assert.AreEqual("179", MahjongPureHand.Solution("2344445667899"));
            Assert.AreEqual("478", MahjongPureHand.Solution("3445556677788"));
        }

        [TestMethod]
        public void RandomTests()
        {
            Assert.AreEqual("6789", MahjongPureHand.Solution("9998874543753"));
            Assert.AreEqual("", MahjongPureHand.Solution("5273773297859")); //出题人的bug 七对
            Assert.AreEqual("15", MahjongPureHand.Solution("9255169714938"));
            Assert.AreEqual("69", MahjongPureHand.Solution("7587781356416"));
            Assert.AreEqual("", MahjongPureHand.Solution("1559334988221")); //出题人的bug 七对
        }
    }
}
