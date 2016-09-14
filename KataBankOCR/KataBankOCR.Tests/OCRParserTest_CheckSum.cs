using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace KataBankOCR.Tests
{
    [TestClass]
    public class OCRParserTest_CheckSum
    {
        [TestMethod]
        public void TestKataBankOCRScanner_Input_457508000()
        {
            // Arrange
            var line1 = "    _  _  _  _  _  _  _  _ ";
            var line2 = "|_||_   ||_ | ||_|| || || |";
            var line3 = "  | _|  | _||_||_||_||_||_|";
            var line4 = "                           ";

            string expected = "457508000";

            // Act
            var parser = new KataBankOCR.OCRParser();
            var actual = parser.Parse(line1, line2, line3, line4, true);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestKataBankOCRScanner_Input_664371495_ERR()
        {
            // Arrange
            var line1 = " _  _     _  _        _  _ ";
            var line2 = "|_ |_ |_| _|  |  ||_||_||_ ";
            var line3 = "|_||_|  | _|  |  |  | _| _|";
            var line4 = "                           ";

            string expected = "664371495 ERR";

            // Act
            var parser = new KataBankOCR.OCRParser();
            var actual = parser.Parse(line1, line2, line3, line4, true);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}