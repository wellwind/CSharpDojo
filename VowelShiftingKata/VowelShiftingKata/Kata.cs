using System;
using System.Collections.Generic;
using System.Linq;

namespace VowelShiftingKata
{
    public static class Kata
    {
        public static string VowelShift(string text, int shift)
        {
            if (shift == 0 || shift == 0)
            {
                return text;
            }

            var vowels = new[] { "a", "e", "i", "o", "u" };
            var vowelsIndex = findVowelsIndex(text, vowels);

            // shift it
            shiftVowelsIndex(shift, vowelsIndex);

            var result = replaceTextByVowelsIndex(text, vowels, vowelsIndex);

            // shift next time
            return VowelShift(result, shift + (shift > 0 ? -1 : 1));
        }

        private static string replaceTextByVowelsIndex(string text, string[] vowels, List<int> vowelsIndex)
        {
            var currentInVowelIndex = 0;
            var result = String.Empty;
            for (var i = 0; i < text.Length; ++i)
            {
                if (vowels.Contains(text[i].ToString().ToLower()))
                {
                    result += text[vowelsIndex[currentInVowelIndex]];
                    ++currentInVowelIndex;
                }
                else
                {
                    result += text[i];
                }
            }
            return result;
        }

        private static void shiftVowelsIndex(int shift, List<int> vowelsIndex)
        {
            if (shift > 0) // shift to right
            {
                vowelsIndex.Insert(0, vowelsIndex.Last());
                vowelsIndex.RemoveAt(vowelsIndex.Count - 1);
            }
            else // shift to left
            {
                vowelsIndex.Add(vowelsIndex.First());
                vowelsIndex.RemoveAt(0);
            }
        }

        private static List<int> findVowelsIndex(string text, string[] vowels)
        {
            var vowelIndex = new List<int>();
            for (var i = 0; i < text.Length; ++i)
            {
                if (vowels.Contains(text[i].ToString().ToLower()))
                {
                    vowelIndex.Add(i);
                }
            }
            return vowelIndex;
        }
    }
}