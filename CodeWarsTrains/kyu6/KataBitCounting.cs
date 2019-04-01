using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kyu6
{
    /// <summary>
    /// Bit Counting
    /// https://www.codewars.com/kata/526571aae218b8ee490006f4
    /// </summary>
    public class KataBitCounting
    {
        public static int CountBits(int n)
        {
            int num = 0;
            do
            {
                if (n % 2 == 1) num++;
                n = n / 2;
            } while (n != 0);
            return num;

            // Best Practices
            //return Convert.ToString(n, 2).Count(x => x == '1');
        }
    }
}
