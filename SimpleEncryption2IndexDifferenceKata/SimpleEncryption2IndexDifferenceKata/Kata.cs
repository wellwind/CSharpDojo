using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleEncryption2IndexDifferenceKata
{
    public class Kata
    {
        public static string Encrypt(string text)
        {
            if (String.IsNullOrEmpty(text))
            {
                return text;
            }
            throw new NotImplementedException();
        }

        public static string Decrypt(string encryptedText)
        {
            if (String.IsNullOrEmpty(encryptedText))
            {
                return encryptedText;
            }
            throw new NotImplementedException();
        }
    }
}