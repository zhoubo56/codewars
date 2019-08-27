using System;
using System.Collections.Generic;
using System.Linq;

namespace kyu4
{
    /// <summary>
    /// Factorial tail
    /// https://www.codewars.com/kata/55c4eb777e07c13528000021
    /// </summary>
    public class FactorialTail
    {
        private static Dictionary<int, int> CanDivisible = null;

        // fixme
        public static int zeroes(int radix, int number)
        {
            //Console.WriteLine($"radix:{radix} number:{number}");
            //int factorial, trailingzeroes = 0;
            //for (factorial = 1; number > 1; factorial *= number--) ;
            //while (factorial % radix == 0) { factorial /= radix; ++trailingzeroes; };
            //return trailingzeroes;

            CanDivisible = new Dictionary<int, int>();
            for (var i = 2; i <= radix; i++)
            {
                if (radix % i == 0) CanDivisible.Add(i, 0);
            }

            var keys = CanDivisible.Keys.Reverse().ToList();
            for (var i = 2; i <= number; i++)
            {
                CalcDivisible(i, keys);
            }

            var trailingZeroes = 0;
            while (CanDivisible.Any(d => d.Value > 0))
            {
                CalcTrailingZeroes(ref trailingZeroes, radix, keys);
            }

            return trailingZeroes;
        }

        private static void CalcDivisible(int number, List<int> keys)
        {
            foreach (var key in keys)
            {
                if (number % key != 0) continue;
                CanDivisible[key]++;
                CalcDivisible(number / key, keys);
                break;
            }
        }

        private static void CalcTrailingZeroes(ref int trailingZeroes, decimal radix, List<int> keys)
        {
            var tmp = 1;
            for (var i = 0; i < keys.Count; i++)
            {
                if (CanDivisible[keys[i]] <= 0) continue;
                tmp *= keys[i];
                if (tmp > radix)
                {
                    tmp /= keys[i];
                    continue;
                }
                CanDivisible[keys[i]]--;
                if (tmp == radix)
                {
                    trailingZeroes++;
                    break;
                }
                else if (i <= keys.Count / 2)
                {
                    if (CanDivisible[keys[keys.Count - i]] > 0)
                    {
                        CanDivisible[keys[keys.Count - i]]--;
                        trailingZeroes++;
                        break;
                    }
                }

                if (radix / tmp != (int)radix / tmp)
                {
                    tmp /= keys[i];
                    CanDivisible[keys[i]]++;
                    continue;
                }
                CalcTrailingZeroes(ref trailingZeroes, radix / tmp, keys);
                break;
            }
        }
    }
}
