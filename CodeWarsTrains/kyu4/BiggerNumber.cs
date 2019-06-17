using System;
using System.Collections.Generic;
using System.Linq;

namespace kyu4
{
    /// <summary>
    /// Next bigger number with the same digits
    /// https://www.codewars.com/kata/next-bigger-number-with-the-same-digits
    /// </summary>
    public class BiggerNumber
    {
        public static long NextBiggerNumber(long n)
        {
            var isMatch = false;
            var listNum = ConvertToList(n);
            for (var i = 0; i < listNum.Count; i++)
            {
                var last = listNum[i];
                var listChangeNum = listNum.GetRange(0, i);
                for (var j = i + 1; j < listNum.Count; j++)
                {
                    listChangeNum.Add(listNum[j]);
                    if (listNum[j] == last ||
                        (listNum[j] > last && listNum[j] < listNum[j - 1])) break;
                    if (listNum[j] > last) continue;
                    listNum[j] = last;

                    if (listChangeNum.Count > 0)
                    {
                        listChangeNum.Sort();
                        for (var k = 0; k < listChangeNum.Count; k++)
                        {
                            listNum[j - 1 - k] = listChangeNum[k];
                        }
                    }

                    isMatch = true;
                    break;
                }

                if (isMatch) break;
            }

            return isMatch && listNum.Last() != 0 ? ConvertToLong(listNum) : -1L;
        }

        private static List<long> ConvertToList(long num)
        {
            var listNum = new List<long>();
            while (num > 0)
            {
                listNum.Add(num % 10);
                num /= 10;
            }
            return listNum;
        }

        private static long ConvertToLong(List<long> listNum)
        {
            return listNum.Select((t, i) => t * (long)Math.Pow(10, i)).Sum();
        }
    }
}
