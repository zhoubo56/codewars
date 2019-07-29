using System;
using System.Linq;

namespace kyu5
{
    /// <summary>
    /// Closest and Smallest
    /// https://www.codewars.com/kata/closest-and-smallest
    /// </summary>
    public class ClosestWeight
    {
        public static int[][] Closest(string strng)
        {
            var result = new int[2][];
            if (string.IsNullOrEmpty(strng)) return result;
            var origins = strng.Split(' ').Select((s) => Convert.ToInt32(s)).ToArray();
            var weights = origins.Select(CalculateWeight).ToArray();

            var distance = int.MaxValue;
            int first = 0, second = 1;
            for (var i = 0; i < weights.Length; i++)
            {
                for (var j = i + 1; j < weights.Length; j++)
                {
                    var tmpD = Math.Abs(weights[i] - weights[j]);
                    if (tmpD < distance)
                    {
                        distance = tmpD;
                        first = i;
                        second = j;
                    }
                    else if (tmpD == distance)
                    {
                        if (weights[i] >= weights[first] && weights[j] >= weights[second]) continue;
                        distance = tmpD;
                        first = i;
                        second = j;
                    }
                }
            }

            if (weights[first] <= weights[second])
            {
                result[0] = new[] {weights[first], first, origins[first]};
                result[1] = new[] {weights[second], second, origins[second]};
            }
            else
            {
                result[0] = new[] { weights[second], second, origins[second] };
                result[1] = new[] { weights[first], first, origins[first] };
            }

            return result;
        }

        private static int CalculateWeight(int num)
        {
            var result = 0;
            while (num > 0)
            {
                result += num % 10;
                num /= 10;
            }

            return result;
        }
    }
}
