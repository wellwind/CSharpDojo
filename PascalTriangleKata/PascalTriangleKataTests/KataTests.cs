using Microsoft.VisualStudio.TestTools.UnitTesting;
using PascalTriangleKata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PascalTriangleKata.Tests
{
    [TestClass()]
    public class KataTests
    {
        [TestMethod()]
        public void PascalsTriangleTest()
        {
            CollectionAssert.AreEqual(
                new List<int> {1},
                Kata.PascalsTriangle(1));
        }
    }
}