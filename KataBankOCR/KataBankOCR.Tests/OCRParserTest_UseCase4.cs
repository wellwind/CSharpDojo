using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace KataBankOCR.Tests
{
    [TestClass]
    public class OCRParserTest_UseCase4
    {
        [TestMethod]
        public void TestKataBankOCRScanner_Input_111111111_Output_711111111()
        {
            // Arrange
            var line1 = "                           ";
            var line2 = "  |  |  |  |  |  |  |  |  |";
            var line3 = "  |  |  |  |  |  |  |  |  |";
            var line4 = "                           ";

            string expected = "711111111";

            // Act
            var parser = new KataBankOCR.OCRParser();
            var actual = parser.Parse(line1, line2, line3, line4, true, true);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestKataBankOCRScanner_Input_777777777_Output_777777177()
        {
            // Arrange
            var line1 = " _  _  _  _  _  _  _  _  _ ";
            var line2 = "  |  |  |  |  |  |  |  |  |";
            var line3 = "  |  |  |  |  |  |  |  |  |";
            var line4 = "                           ";

            string expected = "777777177";

            // Act
            var parser = new KataBankOCR.OCRParser();
            var actual = parser.Parse(line1, line2, line3, line4, true, true);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestKataBankOCRScanner_Input_200000000_Output_200800000()
        {
            // Arrange
            var line1 = " _  _  _  _  _  _  _  _  _ ";
            var line2 = " _|| || || || || || || || |";
            var line3 = "|_ |_||_||_||_||_||_||_||_|";
            var line4 = "                           ";

            string expected = "200800000";

            // Act
            var parser = new KataBankOCR.OCRParser();
            var actual = parser.Parse(line1, line2, line3, line4, true, true);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestKataBankOCRScanner_Input_333333333_Output_333393333()
        {
            // Arrange
            var line1 = " _  _  _  _  _  _  _  _  _ ";
            var line2 = " _| _| _| _| _| _| _| _| _|";
            var line3 = " _| _| _| _| _| _| _| _| _|";
            var line4 = "                           ";

            string expected = "333393333";

            // Act
            var parser = new KataBankOCR.OCRParser();
            var actual = parser.Parse(line1, line2, line3, line4, true, true);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestKataBankOCRScanner_Input_888888888_Output_AMB()
        {
            // Arrange
            var line1 = " _  _  _  _  _  _  _  _  _ ";
            var line2 = "|_||_||_||_||_||_||_||_||_|";
            var line3 = "|_||_||_||_||_||_||_||_||_|";
            var line4 = "                           ";

            string expected = "888888888 AMB ['888886888', '888888880', '888888988']";

            // Act
            var parser = new KataBankOCR.OCRParser();
            var actual = parser.Parse(line1, line2, line3, line4, true, true);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestKataBankOCRScanner_Input_555555555_Output_AMB()
        {
            // Arrange
            var line1 = " _  _  _  _  _  _  _  _  _ ";
            var line2 = "|_ |_ |_ |_ |_ |_ |_ |_ |_ ";
            var line3 = " _| _| _| _| _| _| _| _| _|";
            var line4 = "                           ";

            string expected = "555555555 AMB ['555655555', '559555555']";

            // Act
            var parser = new KataBankOCR.OCRParser();
            var actual = parser.Parse(line1, line2, line3, line4, true, true);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestKataBankOCRScanner_Input_666666666_Output_AMB()
        {
            // Arrange
            var line1 = " _  _  _  _  _  _  _  _  _ ";
            var line2 = "|_ |_ |_ |_ |_ |_ |_ |_ |_ ";
            var line3 = "|_||_||_||_||_||_||_||_||_|";
            var line4 = "                           ";

            string expected = "666666666 AMB ['666566666', '686666666']";

            // Act
            var parser = new KataBankOCR.OCRParser();
            var actual = parser.Parse(line1, line2, line3, line4, true, true);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestKataBankOCRScanner_Input_999999999_Output_AMB()
        {
            // Arrange
            var line1 = " _  _  _  _  _  _  _  _  _ ";
            var line2 = "|_||_||_||_||_||_||_||_||_|";
            var line3 = " _| _| _| _| _| _| _| _| _|";
            var line4 = "                           ";

            string expected = "999999999 AMB ['899999999', '993999999', '999959999']";

            // Act
            var parser = new KataBankOCR.OCRParser();
            var actual = parser.Parse(line1, line2, line3, line4, true, true);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestKataBankOCRScanner_Input_490067715_Output_AMB()
        {
            // Arrange
            var line1 = "    _  _  _  _  _  _     _ ";
            var line2 = "|_||_|| || ||_   |  |  ||_ ";
            var line3 = "  | _||_||_||_|  |  |  | _|";
            var line4 = "                           ";

            string expected = "490067715 AMB ['490067115', '490067719', '490867715']";

            // Act
            var parser = new KataBankOCR.OCRParser();
            var actual = parser.Parse(line1, line2, line3, line4, true, true);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestKataBankOCRScanner_Input_x23456789_Output_123456789()
        {
            // Arrange
            var line1 = "    _  _     _  _  _  _  _ ";
            var line2 = " _| _| _||_||_ |_   ||_||_|";
            var line3 = "  ||_  _|  | _||_|  ||_| _|";
            var line4 = "                           ";

            string expected = "123456789";

            // Act
            var parser = new KataBankOCR.OCRParser();
            var actual = parser.Parse(line1, line2, line3, line4, true, true);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestKataBankOCRScanner_Input_0x0000051_Output_000000051()
        {
            // Arrange
            var line1 = " _     _  _  _  _  _  _    ";
            var line2 = "| || || || || || || ||_   |";
            var line3 = "|_||_||_||_||_||_||_| _|  |";
            var line4 = "                           ";

            string expected = "000000051";

            // Act
            var parser = new KataBankOCR.OCRParser();
            var actual = parser.Parse(line1, line2, line3, line4, true, true);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestKataBankOCRScanner_Input_49086771x_Output_490867715()
        {
            // Arrange
            var line1 = "    _  _  _  _  _  _     _ ";
            var line2 = "|_||_|| ||_||_   |  |  | _ ";
            var line3 = "  | _||_||_||_|  |  |  | _|";
            var line4 = "                           ";

            string expected = "490867715";

            // Act
            var parser = new KataBankOCR.OCRParser();
            var actual = parser.Parse(line1, line2, line3, line4, true, true);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}