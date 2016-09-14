using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace KataBankOCR.Tests
{
    [TestClass]
    public class OCRParserTest_UseCase1
    {
        [TestMethod]
        public void TestKataBankOCRScanner_Input_000000000()
        {
            // Arrange
            var line1 = " _  _  _  _  _  _  _  _  _ ";
            var line2 = "| || || || || || || || || |";
            var line3 = "|_||_||_||_||_||_||_||_||_|";
            var line4 = "                           ";

            string expected = "000000000";

            // Act
            var parser = new KataBankOCR.OCRParser();
            var actual = parser.Parse(line1, line2, line3, line4);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestKataBankOCRScanner_Input_111111111()
        {
            // Arrange
            var line1 = "                           ";
            var line2 = "  |  |  |  |  |  |  |  |  |";
            var line3 = "  |  |  |  |  |  |  |  |  |";
            var line4 = "                           ";

            string expected = "111111111";

            // Act
            var parser = new KataBankOCR.OCRParser();
            var actual = parser.Parse(line1, line2, line3, line4);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestKataBankOCRScanner_Input_222222222()
        {
            // Arrange
            var line1 = " _  _  _  _  _  _  _  _  _ ";
            var line2 = " _| _| _| _| _| _| _| _| _|";
            var line3 = "|_ |_ |_ |_ |_ |_ |_ |_ |_ ";
            var line4 = "                           ";

            string expected = "222222222";

            // Act
            var parser = new KataBankOCR.OCRParser();
            var actual = parser.Parse(line1, line2, line3, line4);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestKataBankOCRScanner_Input_333333333()
        {
            // Arrange
            var line1 = " _  _  _  _  _  _  _  _  _ ";
            var line2 = " _| _| _| _| _| _| _| _| _|";
            var line3 = " _| _| _| _| _| _| _| _| _|";
            var line4 = "                           ";

            string expected = "333333333";

            // Act
            var parser = new KataBankOCR.OCRParser();
            var actual = parser.Parse(line1, line2, line3, line4);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestKataBankOCRScanner_Input_444444444()
        {
            // Arrange
            var line1 = "                           ";
            var line2 = "|_||_||_||_||_||_||_||_||_|";
            var line3 = "  |  |  |  |  |  |  |  |  |";
            var line4 = "                           ";

            string expected = "444444444";

            // Act
            var parser = new KataBankOCR.OCRParser();
            var actual = parser.Parse(line1, line2, line3, line4);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestKataBankOCRScanner_Input_555555555()
        {
            // Arrange
            var line1 = " _  _  _  _  _  _  _  _  _ ";
            var line2 = "|_ |_ |_ |_ |_ |_ |_ |_ |_ ";
            var line3 = " _| _| _| _| _| _| _| _| _|";
            var line4 = "                           ";

            string expected = "555555555";

            // Act
            var parser = new KataBankOCR.OCRParser();
            var actual = parser.Parse(line1, line2, line3, line4);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestKataBankOCRScanner_Input_666666666()
        {
            // Arrange
            var line1 = " _  _  _  _  _  _  _  _  _ ";
            var line2 = "|_ |_ |_ |_ |_ |_ |_ |_ |_ ";
            var line3 = "|_||_||_||_||_||_||_||_||_|";
            var line4 = "                           ";

            string expected = "666666666";

            // Act
            var parser = new KataBankOCR.OCRParser();
            var actual = parser.Parse(line1, line2, line3, line4);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestKataBankOCRScanner_Input_777777777()
        {
            // Arrange
            var line1 = " _  _  _  _  _  _  _  _  _ ";
            var line2 = "  |  |  |  |  |  |  |  |  |";
            var line3 = "  |  |  |  |  |  |  |  |  |";
            var line4 = "                           ";

            string expected = "777777777";

            // Act
            var parser = new KataBankOCR.OCRParser();
            var actual = parser.Parse(line1, line2, line3, line4);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestKataBankOCRScanner_Input_888888888()
        {
            // Arrange
            var line1 = " _  _  _  _  _  _  _  _  _ ";
            var line2 = "|_||_||_||_||_||_||_||_||_|";
            var line3 = "|_||_||_||_||_||_||_||_||_|";
            var line4 = "                           ";

            string expected = "888888888";

            // Act
            var parser = new KataBankOCR.OCRParser();
            var actual = parser.Parse(line1, line2, line3, line4);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestKataBankOCRScanner_Input_999999999()
        {
            // Arrange
            var line1 = " _  _  _  _  _  _  _  _  _ ";
            var line2 = "|_||_||_||_||_||_||_||_||_|";
            var line3 = " _| _| _| _| _| _| _| _| _|";
            var line4 = "                           ";

            string expected = "999999999";

            // Act
            var parser = new KataBankOCR.OCRParser();
            var actual = parser.Parse(line1, line2, line3, line4);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestKataBankOCRScanner_Input_123456789()
        {
            // Arrange
            var line1 = "    _  _     _  _  _  _  _ ";
            var line2 = "  | _| _||_||_ |_   ||_||_|";
            var line3 = "  ||_  _|  | _||_|  ||_| _| ";
            var line4 = "                           ";

            string expected = "123456789";

            // Act
            var parser = new KataBankOCR.OCRParser();
            var actual = parser.Parse(line1, line2, line3, line4);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}