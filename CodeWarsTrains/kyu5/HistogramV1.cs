using System.Linq;

namespace kyu5
{
    /// <summary>
    /// Histogram - V1
    /// https://www.codewars.com/kata/histogram-v1
    /// </summary>
    public class HistogramV1
    {
        public static string Histogram(int[] results)
        {
            var strHistogram = string.Empty;
            var height = results.Max() + 1;
            if (height > 1)
            {
                var width = results.Length * 2;
                var histogram = new string[width, height];
                for (var i = 0; i < width; i++)
                {
                    for (var j = 0; j <= results[i / 2]; j++)
                    {
                        if (i % 2 == 1)
                        {
                            if (j == results[i / 2] && j > 9)
                            {
                                histogram[i, j] = "";
                            }
                            else
                            {
                                histogram[i, j] = " ";
                            }
                        }
                        else
                        {
                            if (j == results[i / 2])
                            {
                                histogram[i, j] = j == 0 ? " " : j.ToString();
                            }
                            else
                            {
                                histogram[i, j] = "#";
                            }
                        }
                    }
                }

                for (var i = height - 1; i >= 0; i--)
                {
                    for (var j = 0; j < width; j++)
                    {
                        strHistogram += histogram[j, i] == null ? " " : histogram[j, i];
                    }

                    strHistogram = strHistogram.TrimEnd() + "\n";
                }
            }

            strHistogram += string.Join("-", results.Select(r => "-").ToArray()) + "\n";
            strHistogram += string.Join(" ", results.Select((r, i) => i + 1).ToArray()) + "\n";
            return strHistogram;
        }
    }
}
