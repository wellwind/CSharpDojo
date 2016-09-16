using IQTestKata;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IQTestKata.Tests
{
    [TestClass()]
    public class KataTests
    {
        [TestMethod]
        public void Test1()
        {
            Assert.AreEqual(3, Kata.IQTest("2 4 7 8 10"));
        }

        [TestMethod]
        public void Test2()
        {
            Assert.AreEqual(1, Kata.IQTest("1 2 2"));
        }
    }
}