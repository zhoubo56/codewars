using System;
using System.Text;
using System.Collections.Generic;
using kyu5;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testkyu5
{
    /// <summary>
    /// Summary description for ZooDisasterTest
    /// </summary>
    [TestClass]
    public class ZooDisasterTest
    {
        [TestMethod]
        public void Example()
        {
            string input = "fox,bug,chicken,grass,sheep";
            string[] expected = {
                "fox,bug,chicken,grass,sheep",
                "chicken eats bug",
                "fox eats chicken",
                "sheep eats grass",
                "fox eats sheep",
                "fox"
            };

            CollectionAssert.AreEqual(expected, ZooDisaster.WhoEatsWho(input));
        }

        [TestMethod]
        public void EmpytyZoo()
        {
            string input = "";
            string[] expected = {
                "",
            };

            CollectionAssert.AreEqual(expected, ZooDisaster.WhoEatsWho(input));
        }

        [TestMethod]
        public void SingleKnownThing()
        {
            string input = "bug";
            string[] expected = {
                "bug",
                "bug"
            };

            CollectionAssert.AreEqual(expected, ZooDisaster.WhoEatsWho(input));
        }
    }
}
