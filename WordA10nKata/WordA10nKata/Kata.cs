using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordA10nKata
{
    public class Kata
    {
        public static string Abbreviate(string input)
        {
            var result = "";
            var tmp = "";
            foreach (var ch in input)
            {
                if ((ch >= 'a' && ch <= 'z') || (ch >= 'A' && ch <= 'Z'))
                {
                    tmp += ch.ToString();
                }
                else
                {
                    result += abbreviateWord(tmp) + ch.ToString();
                    tmp = "";
                }
            }
            return result + abbreviateWord(tmp);
        }

        private static string abbreviateWord(string input)
        {
            if (input.Length <= 3)
            {
                return input;
            }
            else
            {
                return String.Format("{0}{1}{2}", input.First(), input.Length - 2, input.Last());
            }
        }
    }
}