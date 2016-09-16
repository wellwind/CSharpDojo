using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimpleEncryption2IndexDifferenceKata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleEncryption2IndexDifferenceKata.Tests
{
    [TestClass()]
    public class KataTests
    {
        [Ignore]
        [TestMethod]
        public void EncryptExampleTests()
        {
            Assert.AreEqual("$-Wy,dM79H'i'o$n0C&I.ZTcMJw5vPlZc Hn!krhlaa:khV mkL;gvtP-S7Rt1Vp2RV:wV9VuhO Iz3dqb.U0w", Kata.Encrypt("Do the kata \"Kobayashi-Maru-Test!\" Endless fun and excitement when finding a solution!"));
            Assert.AreEqual("5MyQa9p0riYplZc", Kata.Encrypt("This is a test!"));
            Assert.AreEqual("5MyQa79H'ijQaw!Ns6jVtpmnlZ.V6p", Kata.Encrypt("This kata is very interesting!"));
        }

        [Ignore]
        [TestMethod]
        public void DecryptExampleTests()
        {
            Assert.AreEqual("Do the kata \"Kobayashi-Maru-Test!\" Endless fun and excitement when finding a solution!", Kata.Decrypt("$-Wy,dM79H'i'o$n0C&I.ZTcMJw5vPlZc Hn!krhlaa:khV mkL;gvtP-S7Rt1Vp2RV:wV9VuhO Iz3dqb.U0w"));
            Assert.AreEqual("This is a test!", Kata.Decrypt("5MyQa9p0riYplZc"));
            Assert.AreEqual("This kata is very interesting!", Kata.Decrypt("5MyQa79H'ijQaw!Ns6jVtpmnlZ.V6p"));
        }

        [TestMethod]
        public void EmptyTests()
        {
            Assert.AreEqual("", Kata.Encrypt(""));
            Assert.AreEqual("", Kata.Decrypt(""));
        }

        [TestMethod]
        public void NullTests()
        {
            Assert.AreEqual(null, Kata.Encrypt(null));
            Assert.AreEqual(null, Kata.Decrypt(null));
        }
    }
}