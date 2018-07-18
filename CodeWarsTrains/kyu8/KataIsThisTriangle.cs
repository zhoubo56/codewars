using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kyu8
{
    /// <summary>
    /// Is this a triangle?
    /// https://www.codewars.com/kata/56606694ec01347ce800001b
    /// </summary>
    public class KataIsThisTriangle
    {
        public static bool IsTriangle(int a, int b, int c)
        {
            return (a + b > c) && (b + c > a) && (a + c > b);
        }
    }
}
