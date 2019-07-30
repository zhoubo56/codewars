using System.Collections.Generic;
using System.Linq;

namespace kyu5
{
    /// <summary>
    /// John and Ann sign up for Codewars
    /// https://www.codewars.com/kata/john-and-ann-sign-up-for-codewars
    /// </summary>
    public class Johnann
    {
        public static List<long> John(long n)
        {
            return GetNamedList("John", n);
        }

        public static List<long> Ann(long n)
        {
            return GetNamedList("Ann", n);
        }

        public static long SumJohn(long n)
        {
            return GetNamedList("John", n).Aggregate(0L, (current, t) => current + t);
        }

        public static long SumAnn(long n)
        {
            return GetNamedList("Ann", n).Sum();
        }

        private static List<long> GetNamedList(string name, long n)
        {
            var johnList = new List<long>() { 0, 0 };
            var annList = new List<long>() { 1, 1 };
            for (var i = 2; i < n; i++)
            {
                johnList.Add(i - annList[(int)johnList[i - 1]]);
                annList.Add(i - johnList[(int)annList[i - 1]]);
            }
            switch (name)
            {
                case "Ann":
                    return annList;
                case "John":
                    return johnList;
                default:
                    return new List<long>();
            }
        }
    }
}
