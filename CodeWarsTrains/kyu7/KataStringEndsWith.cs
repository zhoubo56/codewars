using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kyu7
{
    /// <summary>
    /// String ends with?
    /// https://www.codewars.com/kata/51f2d1cafc9c0f745c00037d
    /// </summary>
    public class KataStringEndsWith
    {
        public static bool Solution(string str, string ending)
        {
            return str.EndsWith(ending);
        }
    }
}
