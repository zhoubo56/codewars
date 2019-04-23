using System.Collections.Generic;
using kyu4;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testkyu4
{
    /// <summary>
    /// Summary description for CarMileageNumbersTest
    /// </summary>
    [TestClass]
    public class CarMileageNumbersTest
    {
        [TestMethod]
        public void ShouldWorkTest()
        {
            Assert.AreEqual(0, CarMileageNumbers.IsInteresting(3, new List<int>() { 1337, 256 }));
            Assert.AreEqual(1, CarMileageNumbers.IsInteresting(1336, new List<int>() { 1337, 256 }));
            Assert.AreEqual(2, CarMileageNumbers.IsInteresting(1337, new List<int>() { 1337, 256 }));
            Assert.AreEqual(0, CarMileageNumbers.IsInteresting(11208, new List<int>() { 1337, 256 }));
            Assert.AreEqual(1, CarMileageNumbers.IsInteresting(11209, new List<int>() { 1337, 256 }));
            Assert.AreEqual(2, CarMileageNumbers.IsInteresting(11211, new List<int>() { 1337, 256 }));
        }

        [TestMethod]
        public void AdvanceTest()
        {
            Assert.AreEqual(1, CarMileageNumbers.IsInteresting(234567889, new List<int>() { }));
            Assert.AreEqual(1, CarMileageNumbers.IsInteresting(98, new List<int>() { }));
        }
    }
}
