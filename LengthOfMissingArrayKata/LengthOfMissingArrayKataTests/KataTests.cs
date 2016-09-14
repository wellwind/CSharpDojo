using LengthOfMissingArrayKata;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LengthOfMissingArrayKata.Tests
{
    [TestClass()]
    public class KataTests
    {
        [TestMethod()]
        public void GetLengthOfMissingArrayTest()
        {
            Assert.AreEqual(3, Kata.GetLengthOfMissingArray(new object[][] { new object[] { 1, 2 }, new object[] { 4, 5, 1, 1 }, new object[] { 1 }, new object[] { 5, 6, 7, 8, 9 } }));
            Assert.AreEqual(2, Kata.GetLengthOfMissingArray(new object[][] { new object[] { 5, 2, 9 }, new object[] { 4, 5, 1, 1 }, new object[] { 1 }, new object[] { 5, 6, 7, 8, 9 } }));
            Assert.AreEqual(2, Kata.GetLengthOfMissingArray(new object[][] { new object[] { null }, new object[] { null, null, null } }));
            Assert.AreEqual(5, Kata.GetLengthOfMissingArray(new object[][] { new object[] { 'a', 'a', 'a' }, new object[] { 'a', 'a' }, new object[] { 'a', 'a', 'a', 'a' }, new object[] { 'a' }, new object[] { 'a', 'a', 'a', 'a', 'a', 'a' } }));

            Assert.AreEqual(0, Kata.GetLengthOfMissingArray(new object[][] { }));
        }
    }
}