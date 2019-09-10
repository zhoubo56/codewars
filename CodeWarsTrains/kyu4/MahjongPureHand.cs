using System;
using System.Collections.Generic;
using System.Linq;

namespace kyu4
{
    /// <summary>
    /// Mahjong - #1 Pure Hand
    /// https://www.codewars.com/kata/mahjong-number-1-pure-hand
    /// </summary>
    public class MahjongPureHand
    {

        public static string Solution(string tiles)
        {
            Console.WriteLine(tiles);
            var result = string.Empty;

            var keyCountDictionary = new Dictionary<int, int>()
            {
                {1,0 },
                {2,0 },
                {3,0 },
                {4,0 },
                {5,0 },
                {6,0 },
                {7,0 },
                {8,0 },
                {9,0 }
            };
            foreach (var t in tiles)
            {
                var key = int.Parse(t.ToString());
                keyCountDictionary[key]++;
            }

            //不是13张
            if (keyCountDictionary.Values.Sum() != 13) return result;

            for (var i = 1; i <= 9; i++)
            {
                if (IsHu(new Dictionary<int, int>(keyCountDictionary), i))
                {
                    result += i;
                }
            }

            return result;
        }

        private static bool IsHu(Dictionary<int, int> keyCountDictionary, int hu)
        {
            keyCountDictionary[hu]++;
            //一张牌不能超过5张
            if (keyCountDictionary[hu] > 4) return false;
            //七对
            //if (keyCountDictionary.Values.Count(v => v % 2 == 1) == 0) return true;
            //大对子
            if (keyCountDictionary.Values.Count(v => v == 3) == 4)
            {
                if (keyCountDictionary.Values.Count(v => v == 2) == 1) return true;
            }

            //可能的麻将牌
            foreach (var majiang in keyCountDictionary.Where(kv => kv.Value > 1))
            {
                var tmp = new Dictionary<int, int>(keyCountDictionary);
                tmp[majiang.Key] -= 2;
                if (tmp[1] >= 3) tmp[1] -= 3;
                if (tmp[9] >= 3) tmp[9] -= 3;
                if (Think(tmp, 2))
                {
                    return true;
                }
            }

            return false;
        }

        private static bool Think(Dictionary<int, int> keyCountDictionary, int current, bool calcThree = true)
        {
            if (current == 9)
            {
                return keyCountDictionary.Values.Count(v => v > 0) == 0;
            }

            if (keyCountDictionary[current] >= 3 && calcThree)
            {
                var tmp = new Dictionary<int, int>(keyCountDictionary);
                var tmp1 = new Dictionary<int, int>(keyCountDictionary);
                tmp[current] -= 3;
                //先尝试杠排消除，再尝试句子消除
                return Think(tmp, current) || Think(tmp1, current, false);
            }

            if (keyCountDictionary[current] == 0 || keyCountDictionary[current - 1] == 0 || keyCountDictionary[current + 1] == 0) return Think(keyCountDictionary, current + 1);
            keyCountDictionary[current]--;
            keyCountDictionary[current - 1]--;
            keyCountDictionary[current + 1]--;

            return Think(keyCountDictionary, current);
        }
    }
}
