namespace KataBankOCR.OCRPatterns
{
    /// <summary>
    /// 數字的樣式
    /// </summary>
    public interface IDigitPattern
    {
        /// <summary>
        /// 樣式
        /// </summary>
        string[] Pattern { get; }

        /// <summary>
        /// 樣式代表數字
        /// </summary>
        string Digit { get; }
    }
}