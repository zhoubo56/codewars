using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kyu4
{
    /// <summary>
    /// 4 By 4 Skyscrapers
    /// https://www.codewars.com/kata/5671d975d81d6c1c87000022
    /// </summary>
    public class SkyscrapersV1
    {
        static readonly int SkyscraperLength = 4;
        static int[][] _skyscrapers = new int[SkyscraperLength][];

        public static int[][] SolvePuzzle(int[] clues)
        {
            Init();

            while (false == IsFinished())
            {
                for (var i = 0; i < SkyscraperLength; i++)
                {
                    for (var j = 0; j < SkyscraperLength; j++)
                    {
                        if (_skyscrapers[i][j] == 0)
                        {
                            var checkCluesRowResult = CheckCluesRow(i, j, clues);
                            var checkRowResult = CheckRow(i);
                            var checkCluesColumnResult = CheckCluesColumn(i, j, clues);
                            var checkColumnResult = CheckColumn(j);
                            var finalResult = checkCluesRowResult
                                .Intersect(checkRowResult)
                                .Intersect(checkCluesColumnResult)
                                .Intersect(checkColumnResult);
                            if (finalResult.Count() == 1)
                            {
                                _skyscrapers[i][j] = finalResult.FirstOrDefault();
                            }
                        }
                    }
                }
            }

            return _skyscrapers;
        }

        private static IEnumerable<int> CheckCluesRow(int rowIndex, int columnIndex, int[] clues)
        {
            var listMaybeResult = new List<int>();

            var right = clues[1 * SkyscraperLength + rowIndex];
            var left = clues[4 * SkyscraperLength - 1 - rowIndex];
            if ((right == 1 && columnIndex == SkyscraperLength - 1)
                || left == 1 && columnIndex == 0)
            {
                listMaybeResult.Add(SkyscraperLength);
                return listMaybeResult;
            }

            for (var i = 1; i <= SkyscraperLength; i++)
            {
                var tmpRight = 0;
                var tmpLeft = 0;
                for (var j = 0; j < SkyscraperLength; j++)
                {
                    if (_skyscrapers[rowIndex][j] > i && j > columnIndex)
                    {
                        tmpRight++;
                    }
                    if (_skyscrapers[rowIndex][j] < i && j < columnIndex)
                    {
                        tmpLeft++;
                    }
                }

                if ((right == 0 || (right > 0 && tmpRight < right))
                    && (left == 0 || (left > 0 && tmpLeft < left))
                    )
                {
                    listMaybeResult.Add(i);
                }
            }

            return listMaybeResult;
        }

        private static List<int> CheckRow(int rowIndex)
        {
            var listMaybeResult = new List<int>();
            for (var i = 1; i <= SkyscraperLength; i++)
            {
                listMaybeResult.Add(i);
            }
            for (var i = 0; i < SkyscraperLength; i++)
            {
                if (_skyscrapers[rowIndex][i] != 0)
                {
                    listMaybeResult.Remove(_skyscrapers[rowIndex][i]);
                }
            }

            return listMaybeResult;
        }

        private static List<int> CheckCluesColumn(int rowIndex, int columnIndex, int[] clues)
        {
            var listMaybeResult = new List<int>();

            var top = clues[0 * SkyscraperLength + columnIndex];
            var bottom = clues[3 * SkyscraperLength - 1 - columnIndex];
            if (top == 1 && rowIndex == 0
                || bottom == 1 && rowIndex == SkyscraperLength - 1)
            {
                listMaybeResult.Add(SkyscraperLength);
                return listMaybeResult;
            }

            for (var i = 1; i <= SkyscraperLength; i++)
            {
                var tmpTop = 0;
                var tmpBottom = 0;
                for (var j = 0; j < SkyscraperLength; j++)
                {
                    if (_skyscrapers[j][columnIndex] > i && j > rowIndex)
                    {
                        tmpTop++;
                    }
                    if (_skyscrapers[j][columnIndex] < i && j < rowIndex)
                    {
                        tmpBottom++;
                    }
                }

                if ((top == 0 || (top > 0 && tmpTop < top))
                    && (bottom == 0 || (bottom > 0 && tmpBottom < bottom))
                )
                {
                    listMaybeResult.Add(i);
                }
            }

            return listMaybeResult;
        }

        private static List<int> CheckColumn(int columnIndex)
        {
            var listMaybeResult = new List<int>();
            for (var i = 1; i <= SkyscraperLength; i++)
            {
                listMaybeResult.Add(i);
            }
            for (var i = 0; i < SkyscraperLength; i++)
            {
                if (_skyscrapers[i][columnIndex] != 0)
                {
                    listMaybeResult.Remove(_skyscrapers[columnIndex][i]);
                }
            }

            return listMaybeResult;
        }

        private static bool IsFinished()
        {
            for (var i = 0; i < SkyscraperLength; i++)
            {
                for (var j = 0; j < SkyscraperLength; j++)
                {
                    if (_skyscrapers[i][j] == 0)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        private static void Init()
        {
            for (var i = 0; i < SkyscraperLength; i++)
            {
                _skyscrapers[i] = new int[SkyscraperLength];
                for (var j = 0; j < SkyscraperLength; j++)
                {
                    _skyscrapers[i][j] = 0;
                }
            }
        }
    }
}
