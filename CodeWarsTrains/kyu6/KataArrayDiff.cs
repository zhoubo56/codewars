using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kyu6
{
    /// <summary>
    /// Array.diff
    /// https://www.codewars.com/kata/523f5d21c841566fde000009
    /// </summary>
    public class KataArrayDiff
    {
        public static int[] ArrayDiff(int[] a, int[] b)
        {
            foreach (var i in b)
            {
                a = a.Where(k => k != i).ToArray();
            }

            return a;

            //return a.Where(n => !b.Contains(n)).ToArray();
        }
    }
}
