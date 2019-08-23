﻿using System.Linq;

namespace kyu5
{
    public class HistogramH1
    {
        public static string Histogram(int[] results)
        {
            return string.Join("", results.Select((r, i) => (i + 1) + "|" + new string('#', r) + (r > 0 ? (" " + r) : "") + "\n").Reverse());
        }
    }
}
