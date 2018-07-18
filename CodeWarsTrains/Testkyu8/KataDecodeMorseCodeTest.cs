using kyu8;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testkyu8
{
    [TestClass]
    public class KataDecodeMorseCodeTest
    {
        [TestMethod]
        public void TestDecode()
        {
            try
            {
                string input = ".... . -.--   .--- ..- -.. .";
                string expected = "HEY JUDE";

                string actual = KataDecodeMorseCode.Decode(input);

                //目前只支持英文和数字，因为自身摩斯码库的原因
                Assert.AreEqual(expected, actual);
            }
            catch (Exception ex)
            {
                Assert.Fail("There seems to be an error somewhere in your code. Exception message reads as follows: " + ex.Message);
            }
        }
    }
}
