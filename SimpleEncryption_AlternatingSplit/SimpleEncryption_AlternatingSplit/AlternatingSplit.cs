using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleEncryption_AlternatingSplit
{
    public class AlternatingSplit
    {
        public static string Encrypt(string text, int n)
        {
            if (n <= 0 || String.IsNullOrEmpty(text))
            {
                return text;
            }

            var result = "";
            var string1 = "";
            var string2 = "";
            for (var index = 0; index < text.Length; ++index)
            {
                if (index % 2 == 1) // 2nd
                {
                    string1 += text[index].ToString();
                }
                else
                {
                    string2 += text[index].ToString();
                }
            }
            return Encrypt(string1 + string2, n - 1);
        }

        public static string Decrypt(string encryptedText, int n)
        {
            if (n <= 0 || String.IsNullOrEmpty(encryptedText))
            {
                return encryptedText;
            }

            var result = "";
            var string1 = encryptedText.Substring(0, encryptedText.Length / 2); // before part
            var string2 = encryptedText.Substring(string1.Length); // after part
            for (var index = 0; index < string2.Length; ++index)
            {
                result += string2[index].ToString();
                if (string1.Length != index)
                {
                    result += string1[index];
                }
            }
            return Decrypt(result, n - 1);
        }
    }
}