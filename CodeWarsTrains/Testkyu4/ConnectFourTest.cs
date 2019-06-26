using System.Collections.Generic;
using System.Linq;
using kyu4;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testkyu4
{
    [TestClass]
    public class ConnectFourTest
    {
        [TestMethod]
        public void FirstTest()
        {
            List<string> myList = new List<string>()
            {
                "A_Red",
                "B_Yellow",
                "A_Red",
                "B_Yellow",
                "A_Red",
                "B_Yellow",
                "G_Red",
                "B_Yellow"
            };
            Assert.AreEqual("Yellow", ConnectFour.WhoIsWinner(myList), "it should return Yellow");
        }

        [TestMethod]
        public void SecondTest()
        {
            List<string> myList = new List<string>()
            {
                "C_Yellow",
                "E_Red",
                "G_Yellow",
                "B_Red",
                "D_Yellow",
                "B_Red",
                "B_Yellow",
                "G_Red",
                "C_Yellow",
                "C_Red",
                "D_Yellow",
                "F_Red",
                "E_Yellow",
                "A_Red",
                "A_Yellow",
                "G_Red",
                "A_Yellow",
                "F_Red",
                "F_Yellow",
                "D_Red",
                "B_Yellow",
                "E_Red",
                "D_Yellow",
                "A_Red",
                "G_Yellow",
                "D_Red",
                "D_Yellow",
                "C_Red"
            };
            Assert.AreEqual("Yellow", ConnectFour.WhoIsWinner(myList));
        }

        [TestMethod]
        public void ThirdTest()
        {
            List<string> myList = new List<string>()
            {
                "A_Yellow",
                "B_Red",
                "B_Yellow",
                "C_Red",
                "G_Yellow",
                "C_Red",
                "C_Yellow",
                "D_Red",
                "G_Yellow",
                "D_Red",
                "G_Yellow",
                "D_Red",
                "F_Yellow",
                "E_Red",
                "D_Yellow"
            };
            Assert.AreEqual("Red", ConnectFour.WhoIsWinner(myList), "it should return Red");
        }

        [TestMethod]
        public void RandomTest1()
        {
            var myList =
                "C_Yellow-A_Red-D_Yellow-C_Red-E_Yellow-G_Red-A_Yellow-F_Red-F_Yellow-E_Red-C_Yellow-B_Red-A_Yellow-D_Red-E_Yellow-C_Red-B_Yellow-A_Red-C_Yellow-B_Red-A_Yellow-D_Red-D_Yellow-D_Red-D_Yellow-C_Red-A_Yellow-G_Red-F_Yellow-B_Red-F_Yellow-F_Red-E_Yellow-B_Red-B_Yellow-G_Red-E_Yellow-E_Red-F_Yellow-G_Red-G_Yellow-G_Red"
                    .Split('-').ToList();
            Assert.AreEqual("Red", ConnectFour.WhoIsWinner(myList), "it should return Red");
        }

        [TestMethod]
        public void RandomTest2()
        {
            var myList =
                "F_Yellow-E_Red-A_Yellow-B_Red-D_Yellow-D_Red-G_Yellow-B_Red-B_Yellow-F_Red-E_Yellow-C_Red-E_Yellow-G_Red-A_Yellow-B_Red-A_Yellow-A_Red-B_Yellow-B_Red-D_Yellow-E_Red-E_Yellow-G_Red-E_Yellow-F_Red-D_Yellow-A_Red-C_Yellow-C_Red-D_Yellow-F_Red-G_Yellow-G_Red-D_Yellow-C_Red-F_Yellow-A_Red-F_Yellow-G_Red-C_Yellow-C_Red"
                    .Split('-').ToList();
            Assert.AreEqual("Red", ConnectFour.WhoIsWinner(myList), "it should return Red");
        }

        [TestMethod]
        public void RandomTest3()
        {
            var myList =
                "B_Yellow-B_Red-D_Yellow-B_Red-B_Yellow-B_Red-E_Yellow-F_Red-D_Yellow-G_Red-A_Yellow-D_Red-B_Yellow-E_Red-A_Yellow-G_Red-G_Yellow-A_Red-C_Yellow-F_Red-A_Yellow-F_Red-G_Yellow-D_Red-G_Yellow-C_Red-E_Yellow-A_Red-A_Yellow-C_Red-C_Yellow-G_Red-E_Yellow-F_Red-D_Yellow-E_Red-E_Yellow-D_Red-C_Yellow-C_Red-F_Yellow-F_Red"
                    .Split('-').ToList();
            Assert.AreEqual("Yellow", ConnectFour.WhoIsWinner(myList), "it should return Red");
        }
    }
}
