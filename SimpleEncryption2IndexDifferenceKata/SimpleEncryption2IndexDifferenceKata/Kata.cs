using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace SimpleEncryption2IndexDifferenceKata
{
    public class Kata
    {
        private static string availableCharasters =
            "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789.,:;-?! '()$%&\"";

        public static string Encrypt(string text)
        {
            if (String.IsNullOrEmpty(text))
            {
                return text;
            }
            if (text.Any(ch => availableCharasters.IndexOf(ch) == -1))
            {
                throw new Exception();
            }

            var result = String.Empty;
            result = EncryptStep1(text);
            result = EncryptStep2(result);
            result = EncryptStep3(result);

            return result;
        }

        /// <summary>
        /// Step1: For every second char do a switch of the case.
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static string EncryptStep1(string text)
        {
            var result = String.Empty;
            for (int i = 0; i < text.Length; ++i)
            {
                if (i % 2 == 1)
                {
                    result += Char.IsUpper(text[i])
                        ? text[i].ToString().ToLower()
                        : text[i].ToString().ToUpper();
                }
                else
                {
                    result += text[i].ToString();
                }
            }

            return result;
        }

        /// <summary>
        /// Step1: For every char take the index from the region. Take the difference from the region-index of the char before
        /// (from the input text! Not from the fresh encrypted char before!). (Char2 = Char1-Char2)
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static string EncryptStep2(string text)
        {
            var result = text[0].ToString();
            for (int i = 1; i < text.Length; ++i)
            {
                var encryptedCharIndex = availableCharasters.IndexOf(text[i - 1])
                                         - availableCharasters.IndexOf(text[i]);
                if (encryptedCharIndex < 0)
                {
                    encryptedCharIndex += availableCharasters.Length;
                }

                result += availableCharasters[encryptedCharIndex].ToString();
            }

            return result;
        }

        public static string EncryptStep3(string text)
        {
            var firstIndex = availableCharasters.IndexOf(text[0]);
            var encryptedCharIndex = availableCharasters.Length - firstIndex - 1;
            var result = availableCharasters[encryptedCharIndex] + text.Substring(1);

            return result;
        }

        public static string Decrypt(string encryptedText)
        {
            if (String.IsNullOrEmpty(encryptedText))
            {
                return encryptedText;
            }
            if (encryptedText.Any(ch => availableCharasters.IndexOf(ch) == -1))
            {
                throw new Exception();
            }
            throw new NotImplementedException();
        }

        public static string DecryptStep1(string text)
        {
            return EncryptStep3(text);
        }
    }
}