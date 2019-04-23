using System.Collections.Generic;
using System.Linq;

namespace kyu4
{
    /// <summary>
    /// Catching Car Mileage Numbers
    /// https://www.codewars.com/kata/catching-car-mileage-numbers
    /// </summary>
    public class CarMileageNumbers
    {
        public static int IsInteresting(int number, List<int> awesomePhrases)
        {
            for (var i = 0; i < 3; i++)
            {
                var curNumber = number + i;
                if (curNumber < 100) continue;

                if (IsMatchAwesomePhrases(curNumber, awesomePhrases)) return i > 0 ? 1 : 2;
                if (IsAllZeros(curNumber)) return i > 0 ? 1 : 2;
                if (IsSameNumbers(curNumber, curNumber % 10)) return i > 0 ? 1 : 2;

                var list = NumberToList(curNumber);
                if (IsPalindrome(list)) return i > 0 ? 1 : 2;
                if (IsSequential(list, -1)) return i > 0 ? 1 : 2;
                if (list.Last() == 0) list[list.Count - 1] = 10;
                if (IsSequential(list, 1)) return i > 0 ? 1 : 2;
            }

            return 0;
        }

        private static bool IsAllZeros(int number)
        {
            if (number % 10 != 0) return false;
            number /= 10;
            return number < 10 || IsAllZeros(number);
        }

        private static bool IsSameNumbers(int number, int last)
        {
            number /= 10;
            if (number < 10) return number == last;

            return number % 10 == last && IsSameNumbers(number, last);
        }

        private static bool IsSequential(List<int> list, int rate)
        {
            for (var i = 0; i < list.Count - 1; i++)
            {
                if ((list[i] + rate) != list[i + 1])
                {
                    return false;
                }
            }

            return true;
        }

        private static bool IsPalindrome(List<int> list)
        {
            for (var i = 0; i < list.Count / 2; i++)
            {
                if (list[i] != list[list.Count - 1 - i])
                {
                    return false;
                }
            }

            return true;
        }

        private static bool IsMatchAwesomePhrases(int number, List<int> awesomePhrases)
        {
            return awesomePhrases.Contains(number);
        }

        private static List<int> NumberToList(int number)
        {
            var result = new List<int>();
            while (number > 0)
            {
                result.Add(number % 10);
                number /= 10;
            }
            result.Reverse();
            return result;
        }
    }
}
