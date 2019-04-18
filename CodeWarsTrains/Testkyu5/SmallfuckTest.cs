using System;
using System.Text;
using System.Collections.Generic;
using kyu5;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testkyu5
{
    /// <summary>
    /// Summary description for SmallfuckTest
    /// </summary>
    [TestClass]
    public class SmallfuckTest
    {
        [TestMethod, Description("should work for some example test cases")]
        public void ExampleTest()
        {
            // Flips the leftmost cell of the tape
            Assert.AreEqual("10101100", Smallfuck.Interpreter("*", "00101100"));
            // Flips the second and third cell of the tape
            Assert.AreEqual("01001100", Smallfuck.Interpreter(">*>*", "00101100"));
            // Flips all the bits in the tape
            Assert.AreEqual("11010011", Smallfuck.Interpreter("*>*>*>*>*>*>*>*", "00101100"));
            // Flips all the bits that are initialized to 0
            Assert.AreEqual("11111111", Smallfuck.Interpreter("*>*>>*>>>*>*", "00101100"));
            // Goes somewhere to the right of the tape and then flips all bits that are initialized to 1, progressing leftwards through the tape
            Assert.AreEqual("00000000", Smallfuck.Interpreter(">>>>>*<*<<*", "00101100"));
        }

        [TestMethod, Description("should return the final state of the tape immediately if the pointer ever goes out of bounds")]
        public void OutOfBoundsTest()
        {
            Assert.AreEqual("1001101000000111", Smallfuck.Interpreter("*>>>*>*>>*>>>>>>>*>*>*>*>>>**>>**", "0000000000000000"), "Index was outside the bounds of the array");
        }

        [TestMethod, Description("should work for some simple and nested loops")]
        public void NestedLoopsTest()
        {
            Assert.AreEqual("1111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111",
                Smallfuck.Interpreter("*[>*]",
                    $"0000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000"), "Your interpreter should evaluate a simple non-nested loop properly String lengths are both 256.Strings differ at index 2");

            Assert.AreEqual("0000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000",
                Smallfuck.Interpreter("[>*]",
                    $"0000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000"), "Your interpreter should jump to the matching \"]\" when it encounters a \"[\" and the bit under the pointer is 0 String lengths are both 256.Strings differ at index 1.");

            Assert.AreEqual("000", Smallfuck.Interpreter("[[]*>*>*>]", "000"), "Your interpreter should also work properly with nested loops String lengths are both 3.Strings differ at index 0.");
        }
    }
}
