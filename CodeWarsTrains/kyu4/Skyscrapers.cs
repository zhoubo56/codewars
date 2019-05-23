using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Instrumentation;
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
        static int[][] _skyscrapers = new int[SkyscraperLength][];
        static List<int>[][] _listMaybeResult = new List<int>[SkyscraperLength][];

        public static int[][] SolvePuzzle(int[] clues)
        {
            for (var i = 0; i < SkyscraperLength; i++)
            {
                _listMaybeResult[i] = new List<int>[SkyscraperLength];
                _skyscrapers[i] = new int[SkyscraperLength];
                for (var j = 0; j < SkyscraperLength; j++)
                {
                    _listMaybeResult[i][j] = Enumerable.Range(1, SkyscraperLength).ToList();
                }
            }

            var curNum = SkyscraperLength;
            while (curNum != 0)
            {
                for (var i = 0; i < SkyscraperLength; i++)
                {
                    for (var j = 0; j < SkyscraperLength; j++)
                    {
                        var top = clues[0 * SkyscraperLength + j];
                        var right = clues[1 * SkyscraperLength + i];
                        var bottom = clues[3 * SkyscraperLength - 1 - j];
                        var left = clues[4 * SkyscraperLength - 1 - i];

                        if (curNum == SkyscraperLength)
                        {
                            if ((top == 1 && i == 0)
                                || (bottom == 1 && i == SkyscraperLength - 1)
                                || (right == 1 && j == SkyscraperLength - 1)
                                || (left == 1 && j == 0))
                            {
                                ConfirmedNumber(i, j, curNum);
                            }
                        }
                        else
                        {
                            for (var m = 0; m < SkyscraperLength; m++)
                            {
                                
                            }

                            for (var n = 0; n < SkyscraperLength; n++)
                            {

                            }
                        }
                    }
                }

                var lastNum = new Dictionary<int, int>();
                for (var i = 0; i < SkyscraperLength; i++)
                {
                    for (var j = 0; j < SkyscraperLength; j++)
                    {
                        if (_listMaybeResult[i][j].Contains(curNum))
                        {
                            lastNum[i] = j;
                        }
                    }
                }

                if (lastNum.Count != 1) continue;
                ConfirmedNumber(lastNum.FirstOrDefault().Key, lastNum.FirstOrDefault().Value, curNum);
                curNum--;
            }

            return _skyscrapers;
        }

        public static void ConfirmedNumber(int rowIndex, int columnIndex, int num)
        {
            _listMaybeResult[rowIndex][columnIndex].RemoveAll(n => n != num);
            for (var i = 0; i < SkyscraperLength; i++)
            {
                for (var j = 0; j < SkyscraperLength; j++)
                {
                    _listMaybeResult[rowIndex][j].Remove(num);
                    _listMaybeResult[i][columnIndex].Remove(num);
                }
            }
            //_listMaybeResult[rowIndex][columnIndex].Add(num);
            _skyscrapers[rowIndex][columnIndex] = num;
        }
    }
}
