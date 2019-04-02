using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kyu5
{
    /// <summary>
    /// Base64 Encoding
    /// https://www.codewars.com/kata/5270f22f862516c686000161
    /// </summary>
    public static class Base64Utils
    {
        internal static readonly char[] Base64Reference = new char[65]
        {
            'A',
            'B',
            'C',
            'D',
            'E',
            'F',
            'G',
            'H',
            'I',
            'J',
            'K',
            'L',
            'M',
            'N',
            'O',
            'P',
            'Q',
            'R',
            'S',
            'T',
            'U',
            'V',
            'W',
            'X',
            'Y',
            'Z',
            'a',
            'b',
            'c',
            'd',
            'e',
            'f',
            'g',
            'h',
            'i',
            'j',
            'k',
            'l',
            'm',
            'n',
            'o',
            'p',
            'q',
            'r',
            's',
            't',
            'u',
            'v',
            'w',
            'x',
            'y',
            'z',
            '0',
            '1',
            '2',
            '3',
            '4',
            '5',
            '6',
            '7',
            '8',
            '9',
            '+',
            '/',
            '='
        };

        public static string ToBase64(string s)
        {
            var result = string.Empty;
            var suffix = string.Empty;
            var binaryStr = string.Join("", s.Select(c => Convert.ToString((int)c, 2).PadLeft(8, '0')));
            switch (binaryStr.Length % 3)
            {
                case 2:
                    binaryStr += "0";
                    suffix = "==";
                    break;
                case 1:
                    binaryStr += "00";
                    suffix = "=";
                    break;
            }

            if (binaryStr.Length % 6 == 3)
            {
                binaryStr += "000";
            }

            for (var i = 0; i < binaryStr.Length; i = i + 6)
            {
                result += Base64Reference[Convert.ToInt32(binaryStr.Substring(i, 6), 2)];
            }
            return result + suffix;
        }

        public static string FromBase64(string s)
        {
            s = s.TrimEnd('=');
            var result = string.Empty;
            var listBase64Reference = Base64Reference.ToList();
            var binaryStr = string.Join("", s.Select(c => Convert.ToString(listBase64Reference.IndexOf(c), 2).PadLeft(6, '0')));

            binaryStr = binaryStr.Substring(0, binaryStr.Length - binaryStr.Length % 8);
            for (var i = 0; i < binaryStr.Length; i = i + 8)
            {
                result += ((char)Convert.ToInt32(binaryStr.Substring(i, 8), 2)).ToString();
            }
            return result;
        }
    }
}
