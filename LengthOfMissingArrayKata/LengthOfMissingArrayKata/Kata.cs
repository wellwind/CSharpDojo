using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LengthOfMissingArrayKata
{
    public class Kata
    {
        public static int GetLengthOfMissingArray(object[][] arrayOfArrays)
        {
            if (arrayOfArrays == null)
            {
                return 0;
            }

            var lengthArray = arrayOfArrays
              .Select(subArray => subArray == null ? 0 : subArray.Count())
              .OrderBy(len => len)
              .ToArray();

            if (lengthArray.Any(len => len == 0))
            {
                return 0;
            }

            for (var i = 1; i <= lengthArray.Count(); ++i)
            {
                if ((lengthArray[i] - lengthArray[i - 1]) > 1)
                {
                    return lengthArray[i - 1] + 1;
                }
            }
            return 0;
        }
    }
}