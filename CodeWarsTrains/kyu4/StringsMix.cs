using System.Collections.Generic;
using System.Linq;

namespace kyu4
{
    /// <summary>
    /// Strings Mix
    /// https://www.codewars.com/kata/strings-mix 
    /// </summary>
    public class StringsMix
    {
        private const int StartLetter = 97;
        private const int LetterCount = 26;
        private const char Separate = '/';

        public static string Mix(string s1, string s2)
        {
            var s1MixObjects = new List<MixObject>();
            foreach (var c1 in s1)
            {
                CalculateTimes(c1, 1, ref s1MixObjects);
            }

            var s2MixObjects = new List<MixObject>();
            foreach (var c2 in s2)
            {
                CalculateTimes(c2, 2, ref s2MixObjects);
            }

            var allMixObjects = s1MixObjects.Union(s2MixObjects).Where(m => m.Count > 1).ToList();
            foreach (var group in allMixObjects.GroupBy(m => m.Letter))
            {
                var mixObjects = group.ToList();
                if (mixObjects.Count < 2) continue;
                if (mixObjects[0].Count == mixObjects[1].Count)
                {
                    allMixObjects.Remove(mixObjects[1]);
                    allMixObjects.Remove(mixObjects[0]);
                    allMixObjects.Add(new MixObject(mixObjects[0]));
                }
                else if (mixObjects[0].Count > mixObjects[1].Count)
                {
                    allMixObjects.Remove(mixObjects[1]);
                }
                else
                {
                    allMixObjects.Remove(mixObjects[0]);
                }
            }

            var result = allMixObjects.OrderByDescending(m => m.Count).ThenBy(m => m.Belong).ThenBy(m => m.Letter).Aggregate(string.Empty, (current, mixObject) => current + (mixObject + Separate.ToString()));

            return result.TrimEnd(Separate);
        }

        private static void CalculateTimes(char c, int belong, ref List<MixObject> list)
        {
            if (list.Any(m => m.Letter == c))
            {
                var mixObject = list.FirstOrDefault(m => m.Letter == c);
                if (mixObject != null)
                {
                    mixObject.Count += 1;
                }
            }

            if (c >= StartLetter && c < StartLetter + LetterCount)
            {
                list.Add(new MixObject(belong, c));
            }
        }
    }

    public class MixObject
    {
        public MixObject(MixObject mixObject)
        {
            Belong = 3;
            Letter = mixObject.Letter;
            Count = mixObject.Count;
        }

        public MixObject(int belong, char letter)
        {
            Belong = belong;
            Letter = letter;
            Count = 1;
        }

        public int Belong { get; set; }

        public char Letter { get; set; }

        public int Count { get; set; }

        public override string ToString()
        {
            return Belong < 3 ? $"{Belong}:{new string(Letter, Count)}" : $"=:{new string(Letter, Count)}";
        }
    }
}
