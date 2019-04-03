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
    public class Skyscrapers
    {
        static readonly int SkyscraperLength = 4;
        static int[][] _skyscrapers = new[]{
            new []{0, 0, 0, 0},
            new []{0, 0, 0, 0},
            new []{0, 0, 0, 0},
            new []{0, 0, 0, 0},
        };

        public static int[][] SolvePuzzle(int[] clues)
        {
            for (var i = 0; i < SkyscraperLength; i++)
            {
                for (var j = 0; j < SkyscraperLength; j++)
                {

                }
            }

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
                            var checkCluesColumnResult = CheckCluesColumn(j, clues);
                            var checkColumnResult = CheckColumn(j);
                            var finalResult = checkCluesRowResult
                                .Intersect(checkRowResult)
                                .Intersect(checkCluesColumnResult)
                                .Intersect(checkColumnResult);
                            if (finalResult.Count() == 1)
                            {
                                _skyscrapers[i][j] = finalResult.FirstOrDefault();
                                break; ;
                            }
                        }
                    }
                }
            }

            return _skyscrapers;
        }

        private static IEnumerable<int> CheckCluesRow(int rowIndex, int columnIndex, int[] clues)
        {
            var right = clues[1 * SkyscraperLength + rowIndex];
            var left = clues[4 * SkyscraperLength - 1 - rowIndex];

            var listMaybeResult = new List<int>()
            {
                1,2,3,4
            };

            if (right > 0)
            {
                for (int i = columnIndex; i <= SkyscraperLength; i++)
                {
                    
                }
                //for (var i = 0; i < columnIndex; i++)
                //{
                //    for (var j = 1; j <= SkyscraperLength; j++)
                //    {
                //        if (_skyscrapers[rowIndex][i] != 0)
                //        {
                            
                //        }
                //    }
                //}
            }
            if (left > 0)
            {
                for (var i = SkyscraperLength; i > columnIndex ; i--)
                {
                    
                }
            }

            return listMaybeResult;
        }

        private static List<int> CheckRow(int rowIndex)
        {
            var listMaybeResult = new List<int>()
            {
                1,2,3,4
            };
            for (var i = 0; i < SkyscraperLength; i++)
            {
                if (_skyscrapers[rowIndex][i] != 0)
                {
                    listMaybeResult.Remove(_skyscrapers[rowIndex][i]);
                }
            }

            return listMaybeResult;
        }

        private static List<int> CheckCluesColumn(int columnIndex, int[] clues)
        {
            var listMaybeResult = new List<int>()
            {
                1,2,3,4
            };
            for (var i = 0; i < SkyscraperLength; i++)
            {
                if (_skyscrapers[i][columnIndex] != 0)
                {
                    listMaybeResult.Remove(_skyscrapers[columnIndex][i]);
                }
            }

            return listMaybeResult;
        }

        private static List<int> CheckColumn(int columnIndex)
        {
            var listMaybeResult = new List<int>()
            {
                1,2,3,4
            };
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
    }
}
