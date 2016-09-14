using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataBankOCR.OCRPatterns
{
    /// <summary>
    /// 數字0的樣式
    /// </summary>
    public class Pattern0 : IDigitPattern
    {
        /// <summary>
        /// 樣式
        /// </summary>
        /// <value>
        /// The pattern.
        /// </value>
        public string[] Pattern => new string[]
        {
            " _ ",
            "| |",
            "|_|",
            "   "
        };

        /// <summary>
        /// 此樣式代表數字
        /// </summary>
        /// <value>
        /// The digit.
        /// </value>
        public string Digit => "0";
    }
}