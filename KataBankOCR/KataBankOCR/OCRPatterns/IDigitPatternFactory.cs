using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataBankOCR.OCRPatterns
{
    /// <summary>
    /// 數字樣式的工廠介面
    /// </summary>
    public interface IDigitPatternFactory
    {
        /// <summary>
        /// Gets the digit pattern.
        /// </summary>
        /// <param name="digit">The digit.</param>
        /// <returns></returns>
        IDigitPattern GetDigitPattern(int digit);
    }
}