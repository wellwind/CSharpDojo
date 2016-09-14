using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormatNumberAsCurrencyKata
{
    public static class DecimalExtension
    {
        public static string ToCurrency(this Decimal input, string prefix)
        {
            var negative = "";
            if (input < 0)
            {
                negative = "-";
            }

            return String.Format("{0}{1}{2}", negative, prefix, Math.Abs(input).ToString("0.00"));
        }
    }
}