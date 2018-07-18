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
    public class KataComplementaryDNATest
    {
        [TestMethod]
        public void TestMakeComplement()
        {
            Assert.AreEqual("TTTT", KataComplementaryDNA.MakeComplement("AAAA"));

            Assert.AreEqual("TAACG", KataComplementaryDNA.MakeComplement("ATTGC"));

            Assert.AreEqual("CATA", KataComplementaryDNA.MakeComplement("GTAT"));
        }
    }
}
