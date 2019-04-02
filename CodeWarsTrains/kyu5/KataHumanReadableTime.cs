using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kyu5
{
    /// <summary>
    /// Human Readable Time
    /// https://www.codewars.com/kata/52685f7382004e774f0001f7
    /// </summary>
    public class KataHumanReadableTime
    {
        public static string GetReadableTime(int seconds)
        {
            int hour = seconds / 3600;
            seconds = seconds - (hour * 3600);
            int minute = seconds / 60;
            seconds = seconds - (minute * 60);
            return $"{hour.ToString("00")}:{minute.ToString("00")}:{seconds.ToString("00")}";

            //return $"{seconds / 3600:00}:{seconds / 60 % 60:00}:{seconds % 60:00}";
        }
    }
}
