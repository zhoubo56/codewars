using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kyu5
{
    /// <summary>
    /// Directions Reduction
    /// https://www.codewars.com/kata/directions-reduction
    /// </summary>
    public class KataDirectionsReduction
    {
        static Dictionary<string, string> reverseDirection = new Dictionary<string, string>()
        {
            {"NORTH","SOUTH" },
            {"SOUTH","NORTH" },
            {"WEST","EAST" },
            {"EAST","WEST" },
        };

        public static string[] dirReduc(String[] arr)
        {
            Stack<string> pathStack = new Stack<string>();
            string currentReverseDirection = string.Empty;
            foreach (var a in arr)
            {
                if (true == reverseDirection.TryGetValue(a, out currentReverseDirection))
                {
                    if (pathStack.Count > 0 && currentReverseDirection.Equals(pathStack.Peek()))
                    {
                        pathStack.Pop();
                    }
                    else
                    {
                        pathStack.Push(a);
                    }
                }
            }

            return pathStack.Reverse().ToArray();
        }
    }
}
