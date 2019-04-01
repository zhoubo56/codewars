using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kyu7
{
    /// <summary>
    /// Mumbling
    /// https://www.codewars.com/kata/5667e8f4e3f572a8f2000039
    /// </summary>
    public class KataMumbling
    {
        public static String Accum(string s)
        {
            return string.Join("-", s.Select((a, i) => new string(a, 1).ToUpper() + new string(a, i++).ToLower()));
        }
    }
}
