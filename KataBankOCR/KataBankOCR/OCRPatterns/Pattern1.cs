﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataBankOCR.OCRPatterns
{
    /// <summary>
    /// 數字1的樣式
    /// </summary>
    public class Pattern1 : IDigitPattern
    {
        /// <summary>
        /// 樣式
        /// </summary>
        /// <value>
        /// The pattern.
        /// </value>
        public string[] Pattern => new string[]
        {
            "   ",
            "  |",
            "  |",
            "   "
        };

        /// <summary>
        /// 樣式代表數字
        /// </summary>
        public string Digit => "1";
    }
}