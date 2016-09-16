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