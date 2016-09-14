using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuplicateEncoderKata
{
    public class Kata
    {
        public static string DuplicateEncode(string word)
        {
            var symbOnlyOnce = "(";
            var symnMoreOnce = ")";

            var charArray = word.ToCharArray();

            Func<char, char, bool> compareToChar = (ch1, ch2) => ch1.ToString().ToUpper() == ch2.ToString().ToUpper();

            return String.Concat(charArray
              .Select(ch => charArray.Count(val => compareToChar(ch, val)) > 1 ? symnMoreOnce : symbOnlyOnce)
              .ToArray());
        }
    }
}