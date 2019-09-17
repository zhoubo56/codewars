using kyu3;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testkyu3
{
    /// <summary>
    /// Summary description for RailFenceCipherEncodingAndDecodingTest
    /// </summary>
    [TestClass]
    public class RailFenceCipherTest
    {
        [TestMethod]
        public void EncodeSampleTests()
        {
            string[][] encodes =
            {
                new[] { "WEAREDISCOVEREDFLEEATONCE", "WECRLTEERDSOEEFEAOCAIVDEN" },  // 3 rails
                new[] { "Hello, World!", "Hoo!el,Wrdl l" },    // 3 rails
                new[] { "Hello, World!", "H !e,Wdloollr" },    // 4 rails
                new[] { "", "" },                               // 3 rails (even if...)
                new[] { "123456789", "159246837" }
            };
            int[] rails = { 3, 3, 4, 3, 3 };
            for (int i = 0; i < encodes.Length; i++)
            {
                Assert.AreEqual(encodes[i][1], RailFenceCipher.Encode(encodes[i][0], rails[i]));
            }
        }

        [TestMethod]
        public void DecodeSampleTests()
        {
            string[][] decodes =
            {
                new[] { "159246837", "123456789" },
                new[] { "WECRLTEERDSOEEFEAOCAIVDEN", "WEAREDISCOVEREDFLEEATONCE" },    // 3 rails
                new[] { "H !e,Wdloollr", "Hello, World!" },    // 4 rails
                new[] { "", "" }                               // 3 rails (even if...)
            };
            int[] rails = { 3, 3, 4, 3 };
            for (int i = 0; i < decodes.Length; i++)
            {
                Assert.AreEqual(decodes[i][1], RailFenceCipher.Decode(decodes[i][0], rails[i]));
            }
        }

        [TestMethod]
        public void PublisherIdentityPermission()
        {
            //string[][] encodes =
            //{
            //    new[] { "WEAREDISCOVEREDFLEEATONCE", "WEEEAALTRFOEDNDECIRESECVO" },
            //    new[] { "WADCEFACTLROIREESVEEOENED", "WEAREDISCOVEREDFLEEATONCE" }
            //};
            //int[] rails1 = { 10, 8 };
            //for (int i = 0; i < encodes.Length; i++)
            //{
            //    Assert.AreEqual(encodes[i][1], RailFenceCipher.Encode(encodes[i][0], rails1[i]));
            //}

            string[][] decodes =
            {
                new[] { "WEAREDISCOVEREDFLEEATONCE", "WADCEFACTLROIREESVEEOENED" },
            };
            int[] rails2 = { 8 };
            for (int i = 0; i < decodes.Length; i++)
            {
                Assert.AreEqual(decodes[i][1], RailFenceCipher.Decode(decodes[i][0], rails2[i]));
            }
        }
    }
}
