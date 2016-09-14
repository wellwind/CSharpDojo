using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataBankOCR.OCRPatterns
{
    public static class DigitPatternComparer
    {
        public static bool DigitEquals(string[] digit, string[] pattern)
        {
            var areEqual = true;
            for (var i = 0; i < digit.Length; ++i)
            {
                areEqual = digit[i] == pattern[i];
                if (!areEqual)
                {
                    break;
                }
            }

            return areEqual;
        }

        public static bool CheckSumValid(string input)
        {
            if (input.Contains("?"))
            {
                return false;
            }

            var sum = 0;
            for (var index = 8; index >= 0; --index)
            {
                var digit = Convert.ToInt32(input.Substring(index, 1));
                sum += digit * (9 - index);
            }

            return sum % 11 == 0;
        }

        public static bool DigitPatternFamiliar(string[] digit, string[] pattern)
        {
            var diffCount = 0;
            for (var i = 0; i < digit.Length; ++i)
            {
                for (var j = 0; j < 3; ++j)
                {
                    if (digit[i][j].ToString() != pattern[i][j].ToString())
                    {
                        ++diffCount;
                    }
                }
            }

            return diffCount == 1;
        }
    }
}