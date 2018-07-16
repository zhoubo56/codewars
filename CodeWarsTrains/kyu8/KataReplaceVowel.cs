using System.Linq;

namespace kyu8
{
    /// <summary>
    /// Exclamation marks series #11: Replace all vowel to exclamation mark in the sentence
    /// https://www.codewars.com/kata/57fb09ef2b5314a8a90001ed
    /// </summary>
    public static class KataReplaceVowel
    {
        const string Str_Vowel = "aeiouAEIOU";
        public static string Replace(string s)
        {
            return string.Concat(s.Select(ReplaceVowel));
        }
        public static char ReplaceVowel(char symbol)
        {
            return Str_Vowel.Contains(symbol) ? '!' : symbol;
        }
    }
}