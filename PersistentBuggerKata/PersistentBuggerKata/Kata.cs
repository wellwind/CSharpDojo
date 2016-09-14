using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersistentBuggerKata
{
    public class Kata
    {
        public static int Persistence(long n)
        {
            var str = n.ToString();
            var cnt = 0;

            while (str.Length > 1)
            {
                ++cnt;
                long num = 1;
                foreach (var ch in str.ToCharArray())
                {
                    num *= Convert.ToInt64(ch.ToString());
                }
                str = num.ToString();
            }
            return cnt;
        }
    }
}