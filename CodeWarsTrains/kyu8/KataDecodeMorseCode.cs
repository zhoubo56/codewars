using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kyu8
{
    /// <summary>
    /// Decode the Morse code
    /// https://www.codewars.com/kata/54b724efac3d5402db00065e
    /// </summary>
    public class KataDecodeMorseCode
    {
        public static string Decode(string morseCode)
        {
            string humanStr = string.Empty;
            morseCode = morseCode.Replace("   ", "+");
            foreach (var word in morseCode.Split('+'))
            {
                var tmpStr = string.Empty;
                foreach (var letter in word.Split(' '))
                {
                    tmpStr += MorseCode.Get(letter);
                }
                if (false == string.IsNullOrEmpty(tmpStr))
                {
                    humanStr += tmpStr + " ";
                }
            }

            return humanStr.TrimEnd(' ');
        }
    }

    /// <summary>
    /// 模拟摩斯码库
    /// </summary>
    public class MorseCode
    {
        private static Dictionary<string, string> DicMorseCode = new Dictionary<string, string>()
        {
            {".-","A"},
            {"-...","B"},
            {"-.-.","C"},
            {"-..","D"},
            {".","E"},
            {"..-.","F"},
            {"--.","G"},
            {"....","H"},
            {"..","I"},
            {".---","J"},
            {"-.-","K"},
            {".-..","L"},
            {"--","M"},
            {"-.","N"},
            {"---","O"},
            {".--.","P"},
            {"--.-","Q"},
            {".-.","R"},
            {"...","S"},
            {"-","T"},
            {"..-","U"},
            {"...-","V"},
            {".--","W"},
            {"-..-","X"},
            {"-.--","Y"},
            {"--..","Z"},
            {".----","1"},
            {"..---","2"},
            {"...--","3"},
            {"....-","4"},
            {".....","5"},
            {"-....","6"},
            {"--...","7"},
            {"---..","8"},
            {"----.","8"},
            {"-----","0"},
        };

        public static string Get(string letter)
        {
            return DicMorseCode[letter];
        }
    }
}
