using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClockInMirrorKata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClockInMirrorKata.Tests
{
    [TestClass()]
    public class KataTests
    {
        [TestMethod]
        public void FirstTest()
        {
            Assert.AreEqual("06:35", Kata.WhatIsTheTime("05:25"));
        }

        [TestMethod]
        public void SecondTest()
        {
            Assert.AreEqual("11:59", Kata.WhatIsTheTime("12:01"));
        }

        [TestMethod]
        public void ThirdTest()
        {
            Assert.AreEqual("12:02", Kata.WhatIsTheTime("11:58"));
        }

        [TestMethod]
        public void FourhTest()
        {
            Assert.AreEqual("12:00", Kata.WhatIsTheTime("12:00"));
        }

        [TestMethod]
        public void FifthTest()
        {
            Assert.AreEqual("02:00", Kata.WhatIsTheTime("10:00"));
        }
    }
}