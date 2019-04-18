using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kyu5
{
    /// <summary>
    /// The Hunger Games - Zoo Disaster!
    /// https://www.codewars.com/kata/the-hunger-games-zoo-disaster
    /// </summary>
    public class ZooDisaster
    {
        private static readonly Dictionary<string, string> eatList = new Dictionary<string, string>()
        {
            {"antelope","|grass|"},
            {"big-fish","|little-fish|"},
            {"bug","|leaves|"},
            {"bear","|big-fish|bug|chicken|cow|leaves|sheep|"},
            {"chicken","|bug|"},
            {"cow","|grass|"},
            {"fox","|chicken|sheep|"},
            {"giraffe","|leaves|"},
            {"lion","|antelope|cow|"},
            {"panda","|leaves|"},
            {"sheep","|grass|"},
        };

        public static string[] WhoEatsWho(string zoo)
        {
            if (string.IsNullOrEmpty(zoo)) return new[] { "" };
            var animals = zoo.Split(',').ToList();
            var result = new List<string>() { zoo };
            var canEat = true;
            while (canEat)
            {
                for (var i = 0; i < animals.Count; i++)
                {
                    if (eatList.ContainsKey(animals[i]))
                    {
                        if (i > 0 && eatList[animals[i]].Contains($"|{animals[i - 1]}|"))
                        {
                            result.Add($"{animals[i]} eats {animals[i - 1]}");
                            animals.RemoveAt(i - 1);
                            break;
                        }

                        if (i + 1 < animals.Count && eatList[animals[i]].Contains($"|{animals[i + 1]}|"))
                        {
                            result.Add($"{animals[i]} eats {animals[i + 1]}");
                            animals.RemoveAt(i + 1);
                            break;
                        }
                    }

                    if (i == animals.Count - 1)
                    {
                        canEat = false;
                    }
                }
            }
            result.Add(string.Join(",", animals.Select((a) => a)));
            return result.ToArray();
        }
    }
}
