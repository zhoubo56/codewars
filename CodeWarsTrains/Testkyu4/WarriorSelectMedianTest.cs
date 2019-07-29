using System;
using System.Linq;
using Common;
using kyu4;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testkyu4
{
    /// <summary>
    /// Summary description for SelectMedianTest
    /// </summary>
    [TestClass]
    public class WarriorSelectMedianTest
    {
        [TestMethod]
        public void SimpleTest()
        {
            //try
            //{
                var input = new Warrior[]{
                    new Warrior(1),
                    new Warrior(2),
                    new Warrior(3),
                    new Warrior(4),
                    new Warrior(5),
                  };
                Warrior.ResetCompareCount();
                Assert.AreSame(input[3], WarriorSelectMedian.SelectMedian(input));
                Assert.AreEqual(true, Warrior.CompareCount <= 6);
            //}
            //catch (Exception ex)
            //{
            //    Assert.Fail(ex.Message);
            //}
        }

        [TestMethod]
        public void CombinationCombinationTest()
        {

            var warriors = new Warrior[]{
                    new Warrior(1),
                    new Warrior(4),
                    new Warrior(5),
                    new Warrior(3),
                    new Warrior(2),
                };
            var listCombination = PermutationAndCombination<Warrior>.GetPermutation(warriors);

            foreach (var combination in listCombination)
            {
                try
                {
                    //Console.WriteLine(string.Join("-", combination.Select(c => c.m_internal.ToString())));
                    Warrior.ResetCompareCount();
                    var result = WarriorSelectMedian.SelectMedian(combination);
                    //Console.WriteLine(Warrior.CompareCount);
                    Assert.AreSame(warriors[3], result);
                    Assert.AreEqual(true, Warrior.CompareCount <= 6);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message + string.Join("-", combination.Select(c => c.m_internal.ToString())));
                    //Assert.Fail(ex.Message);
                }
            }
        }
    }

    public class Warrior : IWarrior
    {
        public int m_internal { get; set; }

        public static int CompareCount { get; private set; }

        public Warrior(int rank = 0)
        {
            m_internal = rank;
        }

        public bool IsBetter(IWarrior other)
        {
            ++CompareCount;
            if (other == null || !(other is Warrior)) return false;
            return m_internal >= (other as Warrior).m_internal;
        }

        public static void ResetCompareCount()
        {
            CompareCount = 0;
        }
    }
}
