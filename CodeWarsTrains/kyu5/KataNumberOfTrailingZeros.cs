using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kyu5
{
    /// <summary>
    /// Number of trailing zeros of N!
    /// https://www.codewars.com/kata/52f787eb172a8b4ae1000a34
    /// </summary>
    public class KataNumberOfTrailingZeros
    {
        public static int TrailingZeros(int n)
        {
            //思路没问题，但是阶乘中2个因子数肯定大于5的，所以只需要计算5的因子数
            var two = solve(n, 2);
            var five = solve(n, 5);
            return two < five ? two : five;
        }

        private static int solve(int n, int x)
        {
            int cnt = 0;
            while (n > 0) cnt += (n /= x);
            return cnt;
        }
    }
}
