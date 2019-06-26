using System.Collections.Generic;
using System.Text;

namespace kyu4
{
    /// <summary>
    /// Connect Four
    /// https://www.codewars.com/kata/connect-four-1
    /// </summary>
    public class ConnectFour
    {
        private const int WinCount = 4;
        private const int VerticalLength = 6;
        private const int HorizontalLength = 7;
        private const int StartNum = 65; //char "A" ascii code
        private static readonly string[][] Grid = new string[HorizontalLength][];

        public static string WhoIsWinner(List<string> piecesPositionList)
        {
            var result = "Draw";
            for (var i = 0; i < HorizontalLength; i++)
            {
                Grid[i] = new string[VerticalLength];
            }

            foreach (var position in piecesPositionList)
            {
                var positions = position.Split('_');
                var horizontal = GetHorizontal(positions[0]);
                var vertical = NextStep(horizontal, positions[1]);

                if (!CheckWin(horizontal, vertical, positions[1])) continue;
                result = positions[1];
                break;
            }

            return result;
        }

        private static int NextStep(int horizontal, string color)
        {
            var result = -1;
            for (var i = 0; i < VerticalLength; i++)
            {
                if (!string.IsNullOrEmpty(Grid[horizontal][i])) continue;
                Grid[horizontal][i] = color;
                result = i;
                break;
            }

            return result;
        }

        private static bool CheckWin(int horizontal, int vertical, string color)
        {
            return
                (WinCount + 1 <= (MatchCount(horizontal, vertical, 1, 0, color) + MatchCount(horizontal, vertical, -1, 0, color)))
                || (WinCount + 1 <= (MatchCount(horizontal, vertical, 0, 1, color) + MatchCount(horizontal, vertical, 0, -1, color)))
                || (WinCount + 1 <= (MatchCount(horizontal, vertical, 1, 1, color) + MatchCount(horizontal, vertical, -1, -1, color)))
                || (WinCount + 1 <= (MatchCount(horizontal, vertical, 1, -1, color) + MatchCount(horizontal, vertical, -1, 1, color)));
        }

        private static int MatchCount(int horizontal, int vertical, int x, int y, string color)
        {
            if (horizontal < 0 || horizontal >= HorizontalLength || vertical < 0 ||
                vertical >= VerticalLength) return 0;

            if (color.Equals(Grid[horizontal][vertical]))
            {
                return MatchCount(horizontal + x, vertical + y, x, y, color) + 1;
            }

            return 0;
        }

        private static int GetHorizontal(string str)
        {
            var array = Encoding.ASCII.GetBytes(str);
            var ascii = (int)(array[0]);
            return ascii - StartNum;
        }
    }
}
