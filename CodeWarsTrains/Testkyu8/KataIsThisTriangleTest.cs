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
    public class KataIsThisTriangleTest
    {
        [TestMethod]
        public void TestIsTriangle()
        {
            Assert.IsTrue(KataIsThisTriangle.IsTriangle(5, 7, 10));
        }
    }
}
