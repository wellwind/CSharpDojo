using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace KataBankOCR.Tests
{
    [TestClass]
    public class OCRParserTest_UseCase3
    {
        [TestMethod]
        public void TestKataBankOCRScanner_Input_000000051_ILL()
        {
            // Arrange
            var line1 = " _  _  _  _  _  _  _  _    ";
            var line2 = "| || || || || || || ||_   |";
            var line3 = "|_||_||_||_||_||_||_| _|  |";
            var line4 = "                           ";

            string expected = "000000051";

            // Act
            var parser = new KataBankOCR.OCRParser();
            var actual = parser.Parse(line1, line2, line3, line4);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestKataBankOCRScanner_Input_1234x678x_ILL()
        {
            // Arrange
            var line1 = "    _  _     _  _  _  _  _ ";
            var line2 = "  | _| _||_| _ |_   ||_||_|";
            var line3 = "  ||_  _|  | _||_|  ||_| _ ";
            var line4 = "                           ";

            string expected = "1234?678? ILL";

            // Act
            var parser = new KataBankOCR.OCRParser();
            var actual = parser.Parse(line1, line2, line3, line4);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestKataBankOCRScanner_Input_49006771x()
        {
            // Arrange
            var line1 = "    _  _  _  _  _  _     _ ";
            var line2 = "|_||_|| || ||_   |  |  | _ ";
            var line3 = "  | _||_||_||_|  |  |  | _|";
            var line4 = "                           ";

            string expected = "49006771? ILL";

            // Act
            var parser = new KataBankOCR.OCRParser();
            var actual = parser.Parse(line1, line2, line3, line4);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}