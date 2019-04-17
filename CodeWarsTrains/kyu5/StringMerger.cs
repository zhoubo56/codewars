using System.Collections.Generic;

namespace kyu5
{
    /// <summary>
    /// Merged String Checker
    /// https://www.codewars.com/kata/merged-string-checker
    /// </summary>
    public class StringMerger
    {
        public static bool isMerge(string s, string part1, string part2)
        {
            if (s.Length != part1.Length + part2.Length)
            {
                return false;
            }

            int index = 0, index1 = 0, index2 = 0;
            var snapshot = new Stack<int[]>();
            while (index < s.Length)
            {
                if (index1 < part1.Length && s[index] == part1[index1])
                {
                    if (index2 < part2.Length && part1[index1] == part2[index2])
                    {
                        snapshot.Push(new int[] { index + 1, index1, index2 + 1 });
                    }
                    index1++;
                    index++;
                }
                else if (index2 < part2.Length && s[index] == part2[index2])
                {
                    index2++;
                    index++;
                }
                else
                {
                    if (snapshot.Count > 0)
                    {
                        var tmp = snapshot.Pop();
                        index = tmp[0];
                        index1 = tmp[1];
                        index2 = tmp[2];
                    }
                    else
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}
