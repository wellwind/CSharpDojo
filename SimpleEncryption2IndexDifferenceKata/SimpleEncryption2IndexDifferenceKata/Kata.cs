using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleEncryption2IndexDifferenceKata
{
    public class Kata
    {
        private static string availableCharasters =
            "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789.,:;-?!'()$%&";

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
            throw new NotImplementedException();
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
                if (i%2 == 1)
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
    }
}