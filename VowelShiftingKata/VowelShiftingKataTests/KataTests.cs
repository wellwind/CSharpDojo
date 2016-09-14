using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VowelShiftingKata;

namespace VowelShiftingKata.Tests
{
    [TestClass()]
    public class KataTests
    {
        [TestMethod()]
        public void VowelShiftTest()
        {
            Assert.AreEqual("This is a test!", Kata.VowelShift("This is a test!", 0));
        }

        [TestMethod()]
        public void VowelShiftOnceTest()
        {
            Assert.AreEqual("Thes is i tast!", Kata.VowelShift("This is a test!", 1));
        }

        [TestMethod()]
        public void VowelShift3TimesTest()
        {
            Assert.AreEqual("This as e tist!", Kata.VowelShift("This is a test!", 3));
        }

        [TestMethod()]
        public void VowelShiftNegativeThreeTimesTest()
        {
            Assert.AreEqual("Thes is i tast!", Kata.VowelShift("This is a test!", -3));
        }

        [TestMethod()]
        public void VowelShiftUpperCaseTest()
        {
            Assert.AreEqual("e Appla!", Kata.VowelShift("A apple!", 1));
        }
    }
}