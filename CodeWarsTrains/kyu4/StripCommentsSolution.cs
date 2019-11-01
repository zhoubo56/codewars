using System.Linq;

namespace kyu4
{
    /// <summary>
    /// Strip Comments
    /// https://www.codewars.com/kata/strip-comments
    /// </summary>
    public class StripCommentsSolution
    {
        public static string StripComments(string text, string[] commentSymbols)
        {
            text = commentSymbols.Aggregate(text, (current, commentSymbol) => current.Replace(commentSymbol, "#"));
            return string.Join("\n", text.Split('\n').Select(t => t.Split('#').First().TrimEnd()));
        }
    }
}
