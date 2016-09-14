using Microsoft.VisualStudio.TestTools.UnitTesting;
using PersistentBuggerKata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersistentBuggerKata.Tests
{
    [TestClass()]
    public class KataTests
    {
        [TestMethod()]
        public void PersistenceTest()
        {
            Assert.AreEqual(3, Kata.Persistence(39));
            Assert.AreEqual(0, Kata.Persistence(4));
            Assert.AreEqual(2, Kata.Persistence(25));
            Assert.AreEqual(4, Kata.Persistence(999));
        }
    }
}