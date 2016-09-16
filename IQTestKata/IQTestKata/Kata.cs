using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IQTestKata
{
    public class Kata
    {
        public static int IQTest(string numbers)
        {
            var values = numbers
                .Split(new string[] { " " }, StringSplitOptions.None)
                .Select(val => Convert.ToInt32(val))
                .ToList();

            var oddsCount = values.Count(val => val % 2 == 1);

            if (oddsCount == 1)
            {
                return values.IndexOf(values.First(val => val % 2 == 1)) + 1;
            }
            else
            {
                return values.IndexOf(values.First(val => val % 2 == 0)) + 1;
            }
        }
    }
}