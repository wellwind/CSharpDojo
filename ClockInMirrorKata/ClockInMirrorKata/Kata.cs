using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClockInMirrorKata
{
    public class Kata
    {
        public static string WhatIsTheTime(string timeInMirror)
        {
            var hour = Convert.ToInt32(timeInMirror.Substring(0, 2));
            var minute = Convert.ToInt32(timeInMirror.Substring(3, 2));

            if (minute == 0)
            {
                hour = 12 - hour;
            }
            else
            {
                hour = 11 - hour;
                if (hour < 0)
                {
                    hour = 12 + hour;
                }
                minute = 60 - minute;
            }

            if (hour == 0)
            {
                hour = 12;
            }
            return String.Format("{0}:{1}", hour.ToString("00"), minute.ToString("00"));
        }
    }
}