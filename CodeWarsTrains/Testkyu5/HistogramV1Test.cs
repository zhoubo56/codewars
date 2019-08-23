using kyu5;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testkyu5
{
    [TestClass]
    public class HistogramV1Test
    {
        [TestMethod]
        public void BasicTest()
        {
            string expected =
                "    10\n" +
                "    #\n" +
                "    #\n" +
                "7   #\n" +
                "#   #\n" +
                "#   #     5\n" +
                "#   #     #\n" +
                "# 3 #     #\n" +
                "# # #     #\n" +
                "# # # 1   #\n" +
                "# # # #   #\n" +
                "-----------\n" +
                "1 2 3 4 5 6\n";
            Assert.AreEqual(expected, HistogramV1.Histogram(new int[] { 7, 3, 10, 1, 0, 5 }));
        }

        [TestMethod]
        public void ZeroTest()
        {
            string expected =
                "-----------\n" +
                "1 2 3 4 5 6\n";
            
            Assert.AreEqual(expected, HistogramV1.Histogram(new int[] { 0, 0, 0, 0, 0, 0 }));
        }

        [TestMethod]
        public void RandomTest()
        {
            string expected =
                "    11    11\n" +
                "  10#     #\n" +
                "  # #     #\n" +
                "  # # 8   #\n" +
                "  # # #   #\n" +
                "  # # #   #\n" +
                "5 # # # 5 #\n" +
                "# # # # # #\n" +
                "# # # # # #\n" +
                "# # # # # #\n" +
                "# # # # # #\n" +
                "# # # # # #\n" +
                "-----------\n" +
                "1 2 3 4 5 6\n";
            Assert.AreEqual(expected, HistogramV1.Histogram(new int[] { 5, 10, 11, 8, 5, 11 }));
        }
    }
}
