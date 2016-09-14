using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WordA10nKata;

namespace WordA10nKata.Tests
{
    [TestClass()]
    public class KataTests
    {
        [TestMethod]
        public void TestInternationalization()
        {
            Assert.AreEqual("i18n", Kata.Abbreviate("internationalization"));
        }

        [TestMethod]
        public void TestShortSentance()
        {
            Assert.AreEqual("my. dog, isn't f5g v2y w2l.", Kata.Abbreviate("my. dog, isn't feeling very well."));
        }
    }
}