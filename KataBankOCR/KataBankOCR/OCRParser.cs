using KataBankOCR.OCRPatterns;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Diagnostics.Contracts;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace KataBankOCR
{
    /// <summary>
    /// OCR Parser
    /// </summary>
    public class OCRParser
    {
        /// <summary>
        /// Parse line1~4 to digits.
        /// </summary>
        /// <param name="line1">The line1.</param>
        /// <param name="line2">The line2.</param>
        /// <param name="line3">The line3.</param>
        /// <param name="line4">The line4.</param>
        /// <returns>the parse result</returns>
        public string Parse(string line1, string line2, string line3, string line4, bool checkSum = false, bool tryGetValidAccount = false)
        {
            var patterns = initPatterns();

            return parseLinesByPatterns(line1, line2, line3, line4, patterns, checkSum, tryGetValidAccount);
        }

        private string parseLinesByPatterns(string line1, string line2, string line3, string line4, List<IDigitPattern> patterns, bool checkSum, bool tryGetValidAccount)
        {
            var possibleResults = getAllPossibleDigitResults(line1, line2, line3, line4, patterns);

            // combine all first digit as original OCR result
            var originalOCRResult = possibleResults.Aggregate(String.Empty, (current, digit) => current + digit.First());

            if (checkSum && !DigitPatternComparer.CheckSumValid(originalOCRResult))
            {
                originalOCRResult = tryGetValidAccountNumber(tryGetValidAccount, originalOCRResult, possibleResults);
            }
            else if (originalOCRResult.Contains("?"))
            {
                originalOCRResult += " ILL";
            }

            return originalOCRResult;
        }

        private string tryGetValidAccountNumber(bool tryGetValidAccount, string originalOCRResult, List<List<string>> possibleResults)
        {
            originalOCRResult += " ERR";
            if (tryGetValidAccount && originalOCRResult.Count(c => c.ToString().Equals("?")) <= 1)
            {
                var possibleValidAccountNumbers = OCRParserHelper.GetAllPossibleValidAccountNumbers(
                    possibleResults,
                    originalOCRResult);

                if (possibleValidAccountNumbers.Count == 1)
                {
                    originalOCRResult = possibleValidAccountNumbers.First();
                }
                else
                {
                    originalOCRResult = String.Format("{0} AMB [{1}]",
                        originalOCRResult.Replace(" ERR", String.Empty),
                        combinePossibleValidAccountNumbers(possibleValidAccountNumbers));
                }
            }
            return originalOCRResult;
        }

        private string combinePossibleValidAccountNumbers(List<string> possibleValidAccountNumbers)
        {
            return String.Join(", ", possibleValidAccountNumbers
                .OrderBy(acct => acct)
                .Select(acct => String.Format("'{0}'", acct)));
        }

        private static List<List<string>> getAllPossibleDigitResults(string line1, string line2, string line3, string line4, List<IDigitPattern> patterns)
        {
            var possibleResults = new List<List<string>>();

            for (var digitIndex = 1; digitIndex <= 9; ++digitIndex)
            {
                var digitPossibleResult = new List<string>();
                var digitStartIndex = digitIndex * 3 - 3;
                var digit = getOneDigitFromLines(line1, line2, line3, line4, digitStartIndex);

                addDigitPatternCompareResultToPossibleResults(patterns, digit, digitPossibleResult);
                addFamiliarPatternResultToPossibleResult(patterns, digitPossibleResult, digit);

                possibleResults.Add(digitPossibleResult);
            }
            return possibleResults;
        }

        private static void addFamiliarPatternResultToPossibleResult(List<IDigitPattern> patterns, List<string> digitPossibleResult, string[] digit)
        {
            digitPossibleResult.AddRange(
                patterns.Where(pattern =>
                    DigitPatternComparer.DigitPatternFamiliar(digit, pattern.Pattern))
                    .Select(familiarPattern => familiarPattern.Digit));
        }

        private static void addDigitPatternCompareResultToPossibleResults(List<IDigitPattern> patterns, string[] digit,
            List<string> digitPossibleResult)
        {
            var validDigitPattern =
                patterns.FirstOrDefault(pattern => DigitPatternComparer.DigitEquals(digit, pattern.Pattern));
            digitPossibleResult.Add(
                validDigitPattern != null
                    ? validDigitPattern.Digit
                    : "?");
        }

        private static string[] getOneDigitFromLines(string line1, string line2, string line3, string line4, int rangeStart)
        {
            var digit = new string[]
            {
                line1.Substring(rangeStart, 3),
                line2.Substring(rangeStart, 3),
                line3.Substring(rangeStart, 3),
                line4.Substring(rangeStart, 3),
            };
            return digit;
        }

        private static List<IDigitPattern> initPatterns()
        {
            var digitPatternFactory = new DigitPatternFactory();
            var patterns = new List<IDigitPattern>();
            for (var i = 0; i <= 9; ++i)
            {
                var pattern = digitPatternFactory.GetDigitPattern(i);
                if (pattern != null)
                {
                    patterns.Add(pattern);
                }
            }
            return patterns;
        }
    }
}