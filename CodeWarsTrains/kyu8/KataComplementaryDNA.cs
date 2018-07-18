using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kyu8
{
    /// <summary>
    /// Complementary DNA
    /// https://www.codewars.com/kata/554e4a2f232cdd87d9000038
    /// </summary>
    public class KataComplementaryDNA
    {
        public static string MakeComplement(string dna)
        {
            string newDNA = string.Empty;
            var dnaMap = new Dictionary<string, string>();
            dnaMap.Add("A", "T");
            dnaMap.Add("T", "A");
            dnaMap.Add("C", "G");
            dnaMap.Add("G", "C");

            for (int i = 0; i < dna.Length; i++)
            {
                newDNA += dnaMap[dna.Substring(i, 1)];
            }
            return newDNA;
        }
    }
}
