using KataBankOCR.OCRPatterns;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataBankOCR
{
    public static class OCRParserHelper
    {
        public static List<string> GetAllPossibleValidAccountNumbers(List<List<string>> possibleResults, string originalOCRResult)
        {
            var possibleAccountNumbers = new List<string>();
            permutationsPossibleAcountNumberToList(possibleResults, 0, "", possibleAccountNumbers);

            var possibleValidAccountNumbers = new List<string>();
            foreach (var possibleAcct in possibleAccountNumbers)
            {
                if (!possibleAcct.Contains("?") // 可能的組合不可在包含問號(?)
                    && onlyOneDigitDiff(possibleAcct, originalOCRResult)  // 只可以改變一個位數("_" or "|")
                    && DigitPatternComparer.CheckSumValid(possibleAcct)) // CheckSum通過
                {
                    possibleValidAccountNumbers.Add(possibleAcct);
                }
            }
            return possibleValidAccountNumbers;
        }

        private static void permutationsPossibleAcountNumberToList(List<List<string>> allPossibleData, int digitIndex, string currentAccountNumber, List<string> result)
        {
            foreach (var possibleDigit in allPossibleData[digitIndex])
            {
                string currentString = currentAccountNumber + possibleDigit;
                if (digitIndex < allPossibleData.Count - 1)
                {
                    permutationsPossibleAcountNumberToList(allPossibleData, digitIndex + 1, currentString, result);
                }
                else
                {
                    result.Add(currentString);
                }
            }
        }

        private static bool onlyOneDigitDiff(string possibleAcct, string originalOcrResult)
        {
            var diffCnt = 0;
            for (var i = 0; i < 9; ++i)
            {
                if (possibleAcct[i] != originalOcrResult[i])
                {
                    ++diffCnt;
                }
            }
            return diffCnt == 1;
        }
    }
}