using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kyu6
{
    /// <summary>
    /// Esolang Interpreters #1 - Introduction to Esolangs and My First Interpreter (MiniStringFuck)
    /// https://www.codewars.com/kata/esolang-interpreters-number-1-introduction-to-esolangs-and-my-first-interpreter-ministringfuck
    /// </summary>
    public class MiniStringFuck
    {
        public static string MyFirstInterpreter(string code)
        {
            var flag = 0;
            var result = string.Empty;
            foreach (var c in code)
            {
                switch (c)
                {
                    case '+':
                        flag++;
                        if (flag == 256) flag = 0;
                        break;
                    case '.':
                        result += ((char)flag).ToString();
                        break;
                    default:
                        break;
                }
            }
            return result;
        }
    }
}
