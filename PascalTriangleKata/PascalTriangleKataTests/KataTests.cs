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
                new List<int> { 1 },
                Kata.PascalsTriangle(1));

            CollectionAssert.AreEqual(
                new List<int> { 1, 1, 1 },
                Kata.PascalsTriangle(2));
        }

        [TestMethod]
        public void PascalsTriangleTestWhenInput4()
        {
            var expected = new List<int> { 1, 1, 1, 1, 2, 1, 1, 3, 3, 1 };

            var actual = Kata.PascalsTriangle(4);

            CollectionAssert.AreEqual(expected, actual);
        }
    }
}