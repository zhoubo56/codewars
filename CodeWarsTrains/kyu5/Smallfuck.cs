using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace kyu5
{
    /// <summary>
    /// Esolang Interpreters #2 - Custom Smallfuck Interpreter
    /// https://www.codewars.com/kata/esolang-interpreters-number-2-custom-smallfuck-interpreter
    /// </summary>
    public class Smallfuck
    {
        public static string Interpreter(string code, string tape)
        {
            //Console.WriteLine($"{code} | {tape}");
            int flag = 0, index = 0;
            var dicBracket = new Dictionary<int, bool>();
            var result = tape.Select((c) => c == '1').ToArray();
            try
            {
                while (index < code.Length && flag < result.Length)
                {
                    switch (code[index])
                    {
                        case '>':
                            if (!dicBracket.Any(d => d.Value)) flag += 1;
                            break;
                        case '<':
                            if (!dicBracket.Any(d => d.Value)) flag -= 1;
                            break;
                        case '*':
                            if (!dicBracket.Any(d => d.Value)) result[flag] = !result[flag];
                            break;
                        case '[':
                            dicBracket.Add(index, !result[flag]);
                            break;
                        case ']':
                            var last = dicBracket.LastOrDefault();
                            if (last.Value)
                            {
                                dicBracket.Remove(last.Key);
                            }
                            else
                            {
                                if (result[flag])
                                {
                                    index = last.Key;
                                }
                                else
                                {
                                    dicBracket.Remove(last.Key);
                                }
                            }
                            break;
                        default:
                            break;
                    }
                    index++;
                }
            }
            catch (Exception ex)
            {
                //should return immediately 
            }

            return string.Join("", result.Select((c) => c ? '1' : '0'));
        }

        public static string InterpreterBak(string code, string tape)
        {
            Console.WriteLine($"{code} | {tape}");
            int flag = 0, index = 0, leftBracket = -1;
            var past = false;
            var result = tape.Select((c) => c == '1').ToArray();
            try
            {
                while (index < code.Length)
                {
                    switch (code[index])
                    {
                        case '>':
                            if (!past) flag += 1;
                            break;
                        case '<':
                            if (!past) flag -= 1;
                            break;
                        case '*':
                            if (!past) result[flag] = !result[flag];
                            break;
                        case '[':
                            if (result[flag])
                            {
                                if (leftBracket == -1)
                                {
                                    leftBracket = index;
                                }
                            }
                            else
                            {
                                past = true;
                            }
                            break;
                        case ']':
                            past = false;
                            if (result[flag])
                            {
                                if (leftBracket > -1) index = leftBracket;
                            }
                            else
                            {
                                leftBracket = -1;
                            }
                            break;
                        default:
                            break;
                    }
                    index++;
                }
            }
            catch (Exception ex)
            {
                //should return immediately 
            }

            return string.Join("", result.Select((c) => c ? '1' : '0'));
        }
    }
}
