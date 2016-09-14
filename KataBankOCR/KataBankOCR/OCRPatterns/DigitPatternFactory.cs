using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataBankOCR.OCRPatterns
{
    /// <summary>
    /// 數字樣式工廠類別
    /// </summary>
    /// <seealso cref="KataBankOCR.OCRPatterns.IDigitPatternFactory" />
    public class DigitPatternFactory : IDigitPatternFactory
    {
        /// <summary>
        /// Gets the digit pattern.
        /// </summary>
        /// <param name="digit">The digit.</param>
        /// <returns></returns>
        public IDigitPattern GetDigitPattern(int digit)
        {
            var patternType = Type.GetType(String.Format("KataBankOCR.OCRPatterns.Pattern{0}", digit));
            if (patternType != null && patternType.GetInterfaces().Contains(typeof(IDigitPattern)))
            {
                return Activator.CreateInstance(patternType) as IDigitPattern;
            }
            return null;
        }
    }
}