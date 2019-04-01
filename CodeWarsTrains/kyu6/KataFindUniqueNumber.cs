using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kyu6
{
    /// <summary>
    /// Find the unique number
    /// https://www.codewars.com/kata/585d7d5adb20cf33cb000235
    /// </summary>
    public class KataFindUniqueNumber
    {
        public static int GetUnique(IEnumerable<int> numbers)
        {
            var tmp = numbers.OrderBy(n => n).ToList();
            if (tmp[0] == tmp[1])
            {
                tmp = numbers.OrderByDescending(n => n).ToList();
            }

            return tmp.FirstOrDefault();

            //return numbers.GroupBy(x => x).Single(x => x.Count() == 1).Key;
        }
    }
}
