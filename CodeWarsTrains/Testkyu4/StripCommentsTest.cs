using kyu4;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testkyu4
{
    [TestClass]
    public class StripCommentsTest
    {
        [TestMethod]
        public void StripComments()
        {
            Assert.AreEqual(
                "apples, pears\ngrapes\nbananas",
                StripCommentsSolution.StripComments("apples, pears # and bananas\ngrapes\nbananas !apples", new string[] { "#", "!" }));

            Assert.AreEqual("a\nc\nd", StripCommentsSolution.StripComments("a #b\nc\nd $e f g", new string[] { "#", "$" }));

        }
    }
}
