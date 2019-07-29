using System;

namespace kyu4
{
    /// <summary>
    /// Select median
    /// https://www.codewars.com/kata/select-median
    /// </summary>
    public class WarriorSelectMedian
    {
        public static IWarrior SelectMedian(IWarrior[] warriors)
        {
            IWarrior smaller1, smaller2, bigger1, bigger2;
            if (warriors[0].IsBetter(warriors[1]))
            {
                smaller1 = warriors[1];
                bigger1 = warriors[0];
            }
            else
            {
                smaller1 = warriors[0];
                bigger1 = warriors[1];
            }

            if (warriors[3].IsBetter(warriors[4]))
            {
                smaller2 = warriors[4];
                bigger2 = warriors[3];
            }
            else
            {
                smaller2 = warriors[3];
                bigger2 = warriors[4];
            }

            if (warriors[2].IsBetter(smaller1))
            {
                if (warriors[2].IsBetter(smaller2))
                {
                    Console.WriteLine("pass 1");
                    //if (bigger1.IsBetter(bigger2))
                    //{
                    //    return warriors[2].IsBetter(bigger2) ? bigger2.IsBetter(smaller1) ? bigger2 : smaller1 : warriors[2];
                    //}
                    //else
                    //{
                    //    return warriors[2].IsBetter(bigger1) ? bigger1.IsBetter(smaller2) ? bigger1 : smaller2 : warriors[2];
                    //}
                    if (smaller1.IsBetter(bigger2))
                    {
                        //s2 b2 s1 w2 b1
                        return smaller1;
                    }
                    else if (smaller2.IsBetter(bigger1))
                    {
                        return smaller2;
                    }
                    else
                    {
                        return warriors[2];
                    }
                }
                else
                {
                    Console.WriteLine("pass 2");
                    if (bigger1.IsBetter(smaller2))
                    {
                        return warriors[2].IsBetter(smaller2) ? warriors[2] : smaller2;
                    }
                    else
                    {
                        return warriors[2].IsBetter(bigger1) ? warriors[2] : bigger1;
                    }
                }
            }
            else
            {
                if (warriors[2].IsBetter(smaller2))
                {
                    Console.WriteLine("pass 3");
                    if (bigger2.IsBetter(smaller1))
                    {
                        return warriors[2].IsBetter(smaller1) ? warriors[2] : smaller1;
                    }
                    else
                    {
                        return warriors[2].IsBetter(bigger2) ? warriors[2] : bigger2;
                    }
                }
                else
                {
                    Console.WriteLine("pass 4");
                    if (smaller1.IsBetter(smaller2))
                    {
                        return bigger2.IsBetter(smaller1) ? smaller1 : bigger2;
                    }
                    else
                    {
                        return bigger1.IsBetter(smaller2) ? smaller2 : bigger1;
                    }
                }
            }
        }
    }

    public interface IWarrior
    {
        // a.IsBetter(b) returns true if and only if
        // warrior a is no worse than warrior b, i.e. a>=b
        bool IsBetter(IWarrior other);
    }
}
