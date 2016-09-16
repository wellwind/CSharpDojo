using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PascalTriangleKata
{
    public class Kata
    {
        public static List<int> PascalsTriangle(int n)
        {
            if (n == 1) return new List<int>() { 1 };
            if (n == 2) return new List<int>() { 1, 1, 1 };

            var result = new List<int>() { 1, 1, 1 };
            var tmp = new List<int>() { 1, 1 };

            for (var i = 3; i <= n; ++i)
            {
                var currentLevelData = new List<int>();

                currentLevelData.Add(1);
                for (var j = 1; j <= i - 2; ++j)
                {
                    currentLevelData.Add(tmp[j - 1] + tmp[j]);
                }
                currentLevelData.Add(1);

                result.AddRange(currentLevelData);
                tmp = currentLevelData;
            }
            return result;
        }
    }
}